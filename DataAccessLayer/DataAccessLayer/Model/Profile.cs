using System;
using System.Collections.Generic;

namespace DataAccessLayer.Model
{
    public class Profile
    {
        public Profile()
        {
            Skills = new List<Skill>();
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public String History { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime JoinDate { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }

        public int AgeInYears()
        {
            TimeSpan age = DateTime.Now - BirthDate;
            int years = (int)(age.TotalDays / 365);
            return years;
        }

        public int LevelProgressInPercent()
        {
            int experienceToNextLevel = (Level*1000);
            float completedPart = (float)Experience/experienceToNextLevel;
            int percentCompleted = (int)(completedPart * 100);
            return percentCompleted;
        }

    }
}
