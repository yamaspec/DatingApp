using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            age = (dob.Date > today.AddYears(-age)) ? age-- : age;
            return age;
        }
    }
}