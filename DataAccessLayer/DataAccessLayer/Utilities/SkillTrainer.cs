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

        public static bool HasSkillReachedNewLevel(int skillId)
        {
            Skill skill = skillsRepository.First(s => s.Id == skillId);
            float experienceToNewLevel = (skill.Level + 1) * 100;
            if (skill.Experience > experienceToNewLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void SkillLevelUp(int skillId, int newLevel)
        {
            Skill skill = skillsRepository.First(s => s.Id == skillId);
            skill.Level = newLevel;
            skillsRepository.Update(skill);
        }

        public static int CalculateXpForWork(float durationInSeconds)
        {
            float durationInMinutes = durationInSeconds / 60;
            float durationInHours = durationInMinutes / 60;
            float gainedExperience = durationInHours * 10;

            return (int)gainedExperience;
        }

        public static void GiveXpToSkill(int id, int xp)
        {
            if (profileRepository != null)
            {
                Skill skillTrained = skillsRepository.First(s => s.Id == id);//profile.Skills.First(s => s.Id == id);

                skillTrained.Experience += (int)xp;

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

        /*public static void TaskCompleted(Severity priority)
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

        }*/

        public static int GetSkillNewLevel(int skillId)
        {
            Skill skill = skillsRepository.First(s => s.Id == skillId);
            int newLevel = skill.Experience / 100;
            return newLevel;
        }
    }
}
