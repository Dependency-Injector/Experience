using Model.Enums;

namespace DataAccessLayer.Utilities
{
    public static class ExperienceDefaultValues
    {
        public static int CreatingTaskXp = 1;

        public static int LowPriorityTaskXp = 1;
        public static int MediumPriorityTaskXp = 2;
        public static int HightPriorityTaskXp = 3;

        public static int ExperiencePerHour = 10;

        public static int GetExperienceForTask(Severity taskSeverity)
        {
            int xpForTaskCompletion = 0;
            switch (taskSeverity)
            {
                case Severity.Low:
                    xpForTaskCompletion = ExperienceDefaultValues.LowPriorityTaskXp;
                    break;

                case Severity.Medium:
                    xpForTaskCompletion = ExperienceDefaultValues.MediumPriorityTaskXp;
                    break;

                case Severity.High:
                    xpForTaskCompletion = ExperienceDefaultValues.HightPriorityTaskXp;
                    break;
            }

            return xpForTaskCompletion;
        }
    }
}
