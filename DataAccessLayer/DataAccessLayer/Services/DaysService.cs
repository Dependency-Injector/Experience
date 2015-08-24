using DataAccessLayer.Repositories;
using Model.Entities;

namespace DataAccessLayer.Services
{
    public class DaysService
    {
        private DayRepository daysRepository;

        public DaysService()
        {
            daysRepository = new DayRepository();
        }

        public Day UpdateExistingDay(int dayId, string thoughts)
        {
            Day day = daysRepository.Get(dayId);
            day.Thoughts = thoughts;

            return day;
        }
    }
}
