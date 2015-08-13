using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Profile
    {
        public Profile()
        {
            
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public String History { get; set; }
        public DateTime BirthDate { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

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
        //public virtual ICollection<Skill> Skills { get; set; } 
    }
}
