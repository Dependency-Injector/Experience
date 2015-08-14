using System.Linq;
using DataAccessLayer.Model;
using DataAccessLayer.Repositories;

namespace PresentationLayer.Others
{
    internal static class SkillTrainer
    {
        private static ProfileRepository profileRepository = new ProfileRepository();
        private static SkillsRepository skillsRepository = new SkillsRepository();

        static SkillTrainer()
        {

        }

        public static void SkillTrained(int id, int duration)
        {
            if (profileRepository != null)
            {
                Profile profile = profileRepository.GetAll().First();
                Skill skillTrained = profile.Skills.First(s => s.Id == id);
                float hours = (float)duration / 360;
                float gainedExperience = hours * 10;

                skillTrained.Experience += (int)gainedExperience;

                profile.Experience += (int)gainedExperience;

                skillsRepository.Update(skillTrained);
                profileRepository.Update(profile);
            }


        }

        public static void TaskCompleted(int priority)
        {
            if (profileRepository != null)
            {
                Profile profile = profileRepository.GetAll().First();
                int experienceGained = 0;
                switch (priority)
                {
                    case 1:
                        experienceGained = 1;
                        break;

                    case 2:
                        experienceGained = 3;
                        break;

                    case 3:
                        experienceGained = 5;
                        break;
                }

                
                profile.Experience += experienceGained;
                profileRepository.Update(profile);
            }
        }
    }
}
