using System;

namespace Model.Entities
{
    public class WorkUnit
    {
        public int Id { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Duration { get; set; }
        
        public virtual Task Task { get; set; }

        public float GetDurationInHours()
        {
            if (Duration.HasValue)
                return Duration.Value/60;
            else
                return 0;
        }
    }
}
