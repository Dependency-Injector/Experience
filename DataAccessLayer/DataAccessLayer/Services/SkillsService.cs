using System;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Classes;
using Model.Entities;
using Model.Enums;

namespace DataAccessLayer.Services
{
    public class SkillsService : ISkillsService
    {
        private ISkillsRepository skillsRepository;
        private IHistoryService historyService;
        private IProfileRepository profilesRepository;

        public SkillsService(ISkillsRepository skillsRepository, IProfileRepository profilesRepository, IHistoryService historyService)
        {
            this.skillsRepository = skillsRepository;
            this.profilesRepository = profilesRepository;
            this.historyService = historyService;
        }

        public Skill CreateNewSkill(int? ownerId, String name)
        {
            Skill skill = new Skill();
            skill.Name = name;
            skill.Level = 1;
            skill.Experience = 0;

            if (ownerId.HasValue)
                skill.Owner = profilesRepository.First(p => p.Id == ownerId.Value);

            return skill;
        }
        
        public void SaveSkill(Skill skillToSave)
        {
            skillsRepository.Add(skillToSave);

            historyService.AddHistoryEvent(HistoryEventType.SkillCreated, skillToSave.Id, description: "", xpGained: null, levelGained: null);
        }

        public void RemoveSkill(int skillToRemoveId)
        {
            Skill skillToRemove = skillsRepository.Get(skillToRemoveId);
            skillsRepository.Delete(skillToRemove);
        }
    }
}
