﻿using System;
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
        public Severity Priority { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? FinishedDate { get; set; }

        public virtual Skill SkillToTrain { get; set; }
        public virtual ICollection<WorkUnit> WorkUnits { get; set; }

        public TimeSpan GetTotalWorkload()
        {
            int totalSecondsSpend = WorkUnits.Sum(wu => wu.Duration).Value;
            TimeSpan workload = new TimeSpan(0, 0, 0, totalSecondsSpend);

            return workload;
        }

        public string GetTotalWorkloadLiteral()
        {
            TimeSpan workload = GetTotalWorkload();
            
            if (workload.TotalSeconds == 0)
            {
                return "-";
            }
            else
            {
                if (workload.TotalHours > 1)
                    return $"{workload.Hours} hours {workload.Minutes} minutes";
                else
                    return $"{workload.Minutes} minutes";
            }
        }

        public string GetPriorityLiteral()
        {
            int priority = (int) Priority;
            return TaskDefaults.Priorities[priority].Name;
        }

        public string GetTotalExperienceGained()
        {
            TimeSpan workload = GetTotalWorkload();
            double exp = workload.TotalHours * 10;
            int expInt = (int) exp;
            if (expInt > 0)
                return $"{(int) exp} XP";
            else
                return "-";
        }
    }
}
