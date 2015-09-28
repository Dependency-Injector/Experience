using Model.Enums;

namespace DataAccessLayer.Utilities
{
    public static class ExperienceDefaultValues
    {
        public static int CreatingTaskXp = 1;

        public static int BaseExperienceForTaskCompletion = 10;
        public static double TrivialPriorityTaskMultiplier = 0.25;
        public static double LowPriorityTaskMultiplier = 0.5;
        public static double MediumPriorityTaskMultiplier = 1;
        public static double HightPriorityTaskMultiplier = 2;

        public static int ExperiencePerHour = 10;
        
        public static double GetSeverityMultiplier(Severity taskSeverity)
        {
            double severityMultiplier = 1;
            switch (taskSeverity)
            {
                case Severity.Trivial:
                    severityMultiplier = ExperienceDefaultValues.TrivialPriorityTaskMultiplier;
                    break;

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

        public static double GetExperienceForWork(double workDurationInSeconds)
        {
            double workDurationInMinutes = workDurationInSeconds / 60;
            double workDurationInHours = workDurationInMinutes / 60;
            double gainedExperience = workDurationInHours * ExperienceDefaultValues.ExperiencePerHour;

            return gainedExperience;
        }
    }
}
