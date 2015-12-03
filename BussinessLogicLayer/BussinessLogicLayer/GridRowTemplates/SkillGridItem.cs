using System;
using System.ComponentModel;

namespace BussinessLogicLayer.Templates
{
    public class SkillGridItem
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Skill name")]
        public String Name { get; set; }

        public String Level { get; set; }
        public String Experience { get; set; }

        public SkillGridItem(int id, String name, String level, String experience)
        {
            Id = id;
            Name = name;
            Level = level;
            Experience = experience;
        }
    }
}
