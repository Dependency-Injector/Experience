using System;
using System.ComponentModel;

namespace BussinessLogicLayer.GridRowTemplates
{
    public class TaskGridItem
    {
        [Browsable(false)]
        public int Id { get; set; }

        public String Name { get; set; }

        [DisplayName("Importance")]
        public String Priority { get; set; }

        public String Deadline { get; set; }

        [DisplayName("Reported work")]
        public String TimeSpent { get; set; }

        public TaskGridItem(int id, String name, String deadline, String timeSpent, String priority)
        {
            Id = id;
            Name = name;
            Deadline = deadline;
            TimeSpent = timeSpent;
            Priority = priority;
        }
    }
}
