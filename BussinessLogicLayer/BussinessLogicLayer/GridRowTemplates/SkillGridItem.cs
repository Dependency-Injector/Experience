using System;
using System.ComponentModel;

namespace BussinessLogicLayer.GridRowTemplates
{
    /// <summary>
    /// Representation of player skill on grid row, displayed on Profile tab 
    /// </summary>
    public class SkillGridItem
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Skill name")]
        public String Name { get; set; }

        public String Experience { get; set; }

        public String Level { get; set; }

        public SkillGridItem(int id, String name, String level, String experience)
        {
            Id = id;
            Name = name;
            Level = level;
            Experience = experience;
        }
    }
}
