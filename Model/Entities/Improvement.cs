using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Model.Entities
{
    public class Improvement
    {
        public Improvement()
        {
        }

        public int Id { get; set; }
        public DateTime Occured { get; set; }
        [Column("Type")]
        public String TypeString
        {
            get { return Type.ToString(); }
            private set { Type = EnumExtensions.ParseEnum<ImprovementType>(value); }
        }
        [Column("Origin")]
        public String OriginString
        {
            get { return Origin.ToString(); }
            private set { Origin = EnumExtensions.ParseEnum<ImprovementOrigin>(value); }
        }
        public int Amount { get; set; }
        public int? AssociatedEntityId { get; set; }
        public virtual Profile Owner { get; set; }
        public virtual Skill AssociatedSkill { get; set; }

        [NotMapped]
        public ImprovementType Type { get; set; }
        [NotMapped]
        public ImprovementOrigin Origin { get; set; }
    }

    public enum ImprovementOrigin
    {
        TaskCreation,
        TaskCompletion,
        DiaryUpdate
    }

    public enum ImprovementType
    {
        ExperienceGained,
        SkillExperienceGained,
        LevelUp,
        SkillLevelUp
    }
}
