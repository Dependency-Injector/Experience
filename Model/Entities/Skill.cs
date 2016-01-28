﻿using System;
using System.Collections.Generic;

namespace Model.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public float HoursTrained { get; set; }

        public virtual Profile Owner { get; set; }
        public virtual IEnumerable<Task> Tasks { get; set; }

        public String GetNewLevelProgress()
        {
            float experienceGainedInThisLevel = Experience - ((Level - 1)*100);
            float percentCompleted = (experienceGainedInThisLevel / GetExperienceWhenNewLevel()) * 100;
            int percentInt = Convert.ToInt32(percentCompleted);
            return $"{percentInt}%";
        }

        public int GetExperienceWhenNewLevel()
        {
            int experienceWhenNextLevel = Level*100;

            if(Level == 1)
                return experienceWhenNextLevel;
            else
            {
                float multiplier = 1.1f;
                experienceWhenNextLevel = (int) (experienceWhenNextLevel*multiplier);
                return experienceWhenNextLevel;
            }
        }

        public bool HasReachedNewLevel()
        {
            float experienceGainedInThisLevel = Experience - ((Level - 1) * 100);
            float percentCompleted = (experienceGainedInThisLevel / GetExperienceWhenNewLevel()) * 100;
            if (percentCompleted >= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // TODO
        public int GetNewLevel()
        {
            int newLevel = (Experience / 100) + 1;
            return newLevel;
        }
    }
}
