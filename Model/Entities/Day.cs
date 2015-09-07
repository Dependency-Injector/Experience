using System;

namespace Model.Entities
{
    public class Day
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public String Thoughts { get; set; }
        public virtual Profile Owner { get; set; }
    }
}
