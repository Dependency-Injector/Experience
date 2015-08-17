using System.Collections.Generic;
using System.Drawing;
using Model.Enums;

namespace Model.Classes
{

    public static class TaskDefaults
    {
        static TaskDefaults()
        {
            PriorityLevel lowPriority = new PriorityLevel(Severity.Low, "Low", Color.Green, Color.DarkGreen);
            PriorityLevel mediumPriority = new PriorityLevel(Severity.Medium, "Medium", Color.Yellow, Color.DarkGoldenrod);
            PriorityLevel highPriority = new PriorityLevel(Severity.High, "High", Color.Red, Color.DarkRed);

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
