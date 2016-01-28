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

        public int GetExperienceWhenNewLevel()
        {
            int experienceWhenNextLevel = Level*100;
            
            if (Level == 1)
            {
                return experienceWhenNextLevel;
            }
            else
            {
                float multiplier = 1.1f;
                experienceWhenNextLevel = (int)(experienceWhenNextLevel * multiplier);
                return experienceWhenNextLevel;
            }
        }

        public int GetExperienceToGainLevel()
        {
            int experienceWhenNextLevel = GetExperienceWhenNewLevel();
            int experienceToGainNextLevel = experienceWhenNextLevel - Experience;
            return experienceToGainNextLevel;
        }

        public int LevelProgressInPercent()
        {
            int experienceToGainLevel = GetExperienceToGainLevel();
            float levelCompletion = (float) (GetExperienceToGainLevel() - experienceToGainLevel)/GetExperienceWhenNewLevel();
            int levelCompletionPercent = (int) (levelCompletion*100);
            return levelCompletionPercent;
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

        public bool HasReachedNewLevel()
        {
            float experienceToNewLevel = Level * 100;
            if (Experience > experienceToNewLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetNewLevel()
        {
            int newLevel = this.Experience / 100 + 1;
            return newLevel;
        }
    }
}
