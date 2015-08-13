using System;
using System.Collections.Generic;

namespace DataAccessLayer.Model
{
    public class Skill
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual IEnumerable<Task> Tasks { get; set; }

        public String GetNewLevelProgress()
        {
            float experienceToNewLevel = Level*100;
            float percentCompleted = ((float)Experience/experienceToNewLevel) * 100;
            return $"{percentCompleted}%";
        }
    }
}
