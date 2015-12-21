using System;
using System.ComponentModel;
using BussinessLogicLayer.Enums;

namespace BussinessLogicLayer.GridRowTemplates
{
    /// <summary>
    /// Representation of task on grid row, displayed on Tasks tab 
    /// </summary>
    public class TaskGridItem
    {
        [Browsable(false)]
        public int Id { get; set; }

        public String Name { get; set; }
        
        [DisplayName("Importance")]
        public String Priority { get; set; }

        public String Deadline { get; set; }

        [Browsable(false)]
        [DisplayName("Reported work")]
        public String TimeSpent { get; set; }

        [Browsable(false)]
        public TaskTextColor TaskTextColor { get; set; }

        public TaskGridItem(int id, String name, String deadline, String timeSpent, String priority, TaskTextColor taskTextColor)
        {
            Id = id;
            Name = name;
            Deadline = deadline;
            TimeSpent = timeSpent;
            Priority = priority;
            TaskTextColor = taskTextColor;
        }
    }
}
