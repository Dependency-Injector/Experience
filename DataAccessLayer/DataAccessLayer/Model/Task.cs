using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Migrations;
using Utilities;

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

        public string GetTotalTimeSpent()
        {
            int totalSecondsSpend = WorkUnits.Sum(wu => wu.Duration).Value;
            int hoursSpend = totalSecondsSpend / 3600;
            int minutesSpend = (totalSecondsSpend - (hoursSpend * 3600)) / 60;

            if(hoursSpend > 0)
                return $"{hoursSpend} hours {minutesSpend} minutes";
            else
                return $"{minutesSpend} minutes";
        }

        public string GetPriorityLiteral(int priority)
        {
            return TaskDefaults.Priorities[priority].Name;
        }
    }
}
