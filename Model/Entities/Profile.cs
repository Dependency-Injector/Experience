using System;
using System.Collections.Generic;
using Utilities;

namespace Model.Entities
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
        public DateTime? BirthDate { get; set; }
        public DateTime JoinDate { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }

        public int? AgeInYears()
        {
            if (BirthDate.HasValue)
            {
                TimeSpan age = DateTime.Now - BirthDate.Value;
                int years = (int) (age.TotalDays/365);
                return years;
            }
            else
            {
                return null;
            }
        }

        public int LevelProgressInPercent()
        {
            int experienceToNextLevel = (Level*1000);
            float completedPart = (float)Experience/experienceToNextLevel;
            int percentCompleted = (int)(completedPart * 100);
            return percentCompleted;
        }

        public int GetDaysSinceFirstDay()
        {
            int daysSinceUserFirstDay = DateTime.Now.GetDaysSince(JoinDate);
            return daysSinceUserFirstDay;
        }

        public int GetDaysSinceFirstDay(DateTime startDay)
        {
            int daysSinceUserFirstDay = startDay.Date.GetDaysSince(JoinDate);
            return daysSinceUserFirstDay;
        }
    }
}
