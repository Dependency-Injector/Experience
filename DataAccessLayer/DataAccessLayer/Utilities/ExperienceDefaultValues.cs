using Model.Enums;

namespace DataAccessLayer.Utilities
{
    public static class ExperienceDefaultValues
    {
        public static int CreatingTaskXp = 1;

        public static int BaseExperienceForTaskCompletion = 10;

        public static double LowPriorityTaskMultiplier = 0.7;
        public static double MediumPriorityTaskMultiplier = 1;
        public static double HightPriorityTaskMultiplier = 1.2;

        public static double EasyTaskMultiplier = 0.5;
        public static double NormalTaskMultiplier = 1;
        public static double HardTaskMultiplier = 1.5;

        // This means xp for tasks will be multiplied by something between 0,8 - 1,3
        public static int RandomMin = 8;
        public static int RandomMax = 13;

        public static int ExperiencePerHour = 100;
        public static int MinimumDiaryEntryWords = 20;
        public static int DiaryEntryxWordsFor1XP = 10;
        public static int DiaryUpdateRandomMin = 8;
        public static int DiaryUpdateRandomMax = 12;

        public static double GetSeverityMultiplier(Severity taskSeverity)
        {
            double severityMultiplier = 1;
            switch (taskSeverity)
            {
                case Severity.Low:
                    severityMultiplier = ExperienceDefaultValues.LowPriorityTaskMultiplier;
                    break;

                case Severity.Medium:
                    severityMultiplier = ExperienceDefaultValues.MediumPriorityTaskMultiplier;
                    break;

                case Severity.High:
                    severityMultiplier = ExperienceDefaultValues.HightPriorityTaskMultiplier;
                    break;

                default:
                    break;
            }

            return severityMultiplier;
        }

        public static double GetDifficultyMultiplier(Difficulty taskDifficulty)
        {
            double difficultyMultiplier = 1;
            switch (taskDifficulty)
            {
                case Difficulty.Easy:
                    difficultyMultiplier = ExperienceDefaultValues.EasyTaskMultiplier;
                    break;

                case Difficulty.Medium:
                    difficultyMultiplier = ExperienceDefaultValues.NormalTaskMultiplier;
                    break;

                case Difficulty.Hard:
                    difficultyMultiplier = ExperienceDefaultValues.HardTaskMultiplier;
                    break;

                default:
                    break;
            }

            return difficultyMultiplier;
        }

        public static double GetExperienceForWork(double workDurationInSeconds)
        {
            double workDurationInMinutes = workDurationInSeconds / 60;
            double workDurationInHours = workDurationInMinutes / 60;
            double gainedExperience = workDurationInHours * ExperienceDefaultValues.ExperiencePerHour;

            return gainedExperience;
        }
    }
}
