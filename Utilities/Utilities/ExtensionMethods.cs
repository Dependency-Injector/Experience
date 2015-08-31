using System;

namespace Utilities
{
    public static class ExtensionMethods
    {
        public static int GetDaysSince(this DateTime date, DateTime startDate)
        {
            double daysBetweenDates = (date - startDate).TotalDays;
            return (int)daysBetweenDates;
        }
    }
}
