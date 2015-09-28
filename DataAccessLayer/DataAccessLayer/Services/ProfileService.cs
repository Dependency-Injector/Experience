using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using Model.Entities;

namespace DataAccessLayer.Services
{
    public class ProfileService : IProfileService
    {
        private ISkillsRepository skillsRepository;
        private IProfileRepository profileRepository;

        public ProfileService(IProfileRepository profileRepository, ISkillsRepository skillsRepository)
        {
            this.skillsRepository = skillsRepository;
            this.profileRepository = profileRepository;
        }

        public void UserGainedExperience(int userId, int experienceGained)
        {
            Profile user = profileRepository.Get(userId);
            if (user != null)
            {
                user.Experience += experienceGained;
                profileRepository.Update(user);
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
