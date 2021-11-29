using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Helpers
{
    public static class Helpers
    {
        public static int GetCurrentAge(this DateTimeOffset date)
        {
            TimeSpan age = DateTime.Now.Subtract(date.DateTime);
            return ConvertDaysToYears(age);
        }

        public static int ConvertDaysToYears(TimeSpan age) {
            return (int)(age.Days / 365.2425);
        }
    }
}
