using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Experience { get; set; }
        public int ExperienceWhenNextLevel { get; set; }
        public int Level { get; set; }
        public float HoursTrained { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual IEnumerable<Task> Tasks { get; set; }

        public String GetNewLevelProgress()
        {
            float experienceGainedInThisLevel = Experience - ((Level - 1)*100);
            float percentCompleted = experienceGainedInThisLevel / 100;
            int percentInt = Convert.ToInt32(percentCompleted*100);
            return $"{percentInt}%";
        }
    }
}
