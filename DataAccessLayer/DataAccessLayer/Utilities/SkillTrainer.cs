using System.Linq;
using DataAccessLayer.Repositories;
using Model.Entities;
using Model.Enums;

namespace DataAccessLayer.Utilities
{
    public static class SkillTrainer
    {
        private static ProfileRepository profileRepository = new ProfileRepository();
        private static SkillsRepository skillsRepository = new SkillsRepository();
        
        static SkillTrainer()
        {

        }

        public static void SkillTrained(int id, float durationInSeconds)
        {
            if (profileRepository != null)
            {
                //Profile profile = profileRepository.GetAll().First();
                Skill skillTrained = skillsRepository.First(s => s.Id == id);//profile.Skills.First(s => s.Id == id);
                float durationInMinutes = durationInSeconds / 60;
                float durationInHours = durationInMinutes / 60;
                float gainedExperience = durationInHours * 10;
                float experienceToNewLevel = (skillTrained.Level + 1) * 100;

                skillTrained.Experience += (int)gainedExperience;

                if (skillTrained.Experience > experienceToNewLevel)
                {
                    int newLevel = skillTrained.Experience/100;
                    skillTrained.Level = newLevel;
                }

                skillsRepository.Update(skillTrained);
            }
        }

        public static void GiveXp(int xp)
        {
            if (profileRepository != null)
            {
                Profile profile = profileRepository.GetAll().First();
                profile.Experience += xp;
                profileRepository.Update(profile);
            }
        }

        public static void TaskCompleted(Severity priority)
        {
            if (profileRepository != null)
            {
                Profile profile = profileRepository.GetAll().First();
                int experienceGained = 0;
                switch (priority)
                {
                    case Severity.Low:
                        experienceGained = ExperienceDefaultValues.LowPriorityTaskXp;
                        break;

                    case Severity.Medium:
                        experienceGained = ExperienceDefaultValues.MediumPriorityTaskXp;
                        break;

                    case Severity.High:
                        experienceGained = ExperienceDefaultValues.HightPriorityTaskXp;
                        break;
                }

                
                profile.Experience += experienceGained;
                profileRepository.Update(profile);
            }

        }

    }
}
