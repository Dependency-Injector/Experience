using System.Collections.Generic;
using System.Drawing;

namespace Utilities
{

    public static class TaskDefaults
    {
        static TaskDefaults()
        {
            PriorityLevel lowPriority = new PriorityLevel(Severity.Low, "Low", Color.Green);
            PriorityLevel mediumPriority = new PriorityLevel(Severity.Medium, "Medium", Color.Yellow);
            PriorityLevel highPriority = new PriorityLevel(Severity.High, "High", Color.Red);

            Priorities = new Dictionary<int, PriorityLevel>
            {
                { 1, lowPriority},
                { 2, mediumPriority},
                { 3, highPriority}
            };
        }

        public static Dictionary<int, PriorityLevel> Priorities;
    }
}
