using System;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using Model.Entities;
using Model.Enums;

namespace DataAccessLayer.Services
{
    public class ProfileService : IProfileService
    {
        private ISkillsRepository skillsRepository;
        private IProfileRepository profileRepository;
        private IHistoryService historyService;
     
        public ProfileService(IProfileRepository profileRepository, ISkillsRepository skillsRepository, IHistoryService historyService)
        {
            this.skillsRepository = skillsRepository;
            this.profileRepository = profileRepository;
            this.historyService = historyService;
        }

        public Profile CreateNewProfile(String name)
        {
            Profile profile = new Profile();
            profile.Name = name;
            profile.BirthDate = null;
            profile.JoinDate = DateTime.Now;
            profile.Experience = 0;
            profile.Level = 1;

            return profile;
        }

        public void UserGainedExperience(int userId, int experienceGained)
        {
            Profile user = profileRepository.Get(userId);
            if (user != null)
            {
                user.Experience += experienceGained;
                profileRepository.Update(user);
                historyService.AddHistoryEvent(HistoryEventType.ExperienceGained, null, "", experienceGained, null);
            }

            if (user.HasReachedNewLevel())
            {
                int newLevel = user.GetNewLevel();
                UserReachedNewLevel(user.Id, newLevel);
                historyService.AddHistoryEvent(HistoryEventType.LevelGained, user.Id, "", levelGained: newLevel);
            }
        }

        public void UserSkillGainedExperience(int skillId, int experienceGained)
        {
            Skill skillTrained = skillsRepository.Get(skillId);
            if (skillTrained != null)
            {
                skillTrained.Experience += experienceGained;
                skillsRepository.Update(skillTrained);
            }

            // Check if skill leveled up
            if (skillTrained.HasReachedNewLevel())
            {
                // Give skill new level
                int skillNewLevel = skillTrained.GetNewLevel();
                UserSkillReachedNewLevel(skillTrained.Id, skillNewLevel);
                historyService.AddHistoryEvent(HistoryEventType.SkillLevelGained, skillTrained.Id, newLevel: skillNewLevel);
            }
        }

        public void UserSkillReachedNewLevel(int skillId, int levelReached)
        {
            Skill skill = skillsRepository.Get(skillId);
            if (skill != null)
            {
                skill.Level = levelReached;
                skillsRepository.Update(skill);
            }
        }

        public void UserReachedNewLevel(int userId, int levelReached)
        {
            Profile user = profileRepository.Get(userId);
            if (user != null)
            {
                user.Level = levelReached;
                profileRepository.Update(user);
            }
        }
        
    }
}
