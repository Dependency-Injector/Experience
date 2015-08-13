using System;
using System.Collections;
using System.Collections.Generic;
using DataAccessLayer.Migrations;

namespace DataAccessLayer.Model
{
    public class Task
    {
        public Task()
        {
            WorkUnits = new List<WorkUnit>();
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsFinished { get; set; }
        public int Priority { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? FinishedDate { get; set; }

        public virtual Skill SkillToTrain { get; set; }
        public virtual ICollection<WorkUnit> WorkUnits { get; set; }
    }
}
