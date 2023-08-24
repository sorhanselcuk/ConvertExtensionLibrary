using ConvertExtensionLibrary.Exceptions.DateTimeExtensionExceptions;
using System;
using System.Linq;
using System.Threading;

namespace ConvertExtensionLibrary.Concrete
{
    public static class DateTimeExtension
    {
        public static DateTime ConvertToDateTimeFromJulianDate(this string value)
        {
            if (value.Length < 6)
                throw new IncorrectJulianFormatException("Julian date format should be minimum 6 character.");
            if (!CheckIsAllCharactersAreNumber(value))
                throw new IncorrectJulianFormatException("All characters are should be number.");

            int dayValue = string.Join("", value.TakeLast(3)).AsInteger();
            int yearValue = string.Join("", value.SkipLast(3).TakeLast(2)).AsInteger();
            int centuryValue = string.Join("", value.SkipLast(5)).AsInteger();
            if (dayValue > 366)
                throw new DayGreaterThan366Exception();
            if (dayValue < 1)
                throw new DayLessThan1Exception();
            int year = ((19 + centuryValue) * 100) + yearValue;
            if (year % 4 != 0 && dayValue > 365)
                throw new DayGreaterThan365Exception();

            DateTime resultDateTime = new DateTime(year, 1, 1).AddDays((dayValue - 1));
            return resultDateTime;
        }
        public static string ConvertToJulianDate(this DateTime dateTime)
        {
            string julianDate = string.Empty;
            if (dateTime == default)
                throw new ArgumentNullException("DateTime is not should be null.");
            int year = dateTime.Year;
            int dayOfYear = dateTime.DayOfYear;

            int julianYear = (year % 1000);
            int julianCentury = (((year - julianYear) / 100) - 19);
            julianDate = string.Join("", julianCentury.ToString(), ConvertJulianYearFormat(julianYear), ConvertJulianDayFormat(dayOfYear));
            return julianDate;
        }
        private static string ConvertJulianDayFormat(int day)
        {
            string result = string.Empty;
            int expectedZeroCount = (3 - day.ToString().Length);
            for (int i = 0; i < expectedZeroCount; i++)
            {
                result += "0";
            }
            result += day.ToString();
            return result;
        }
        private static string ConvertJulianYearFormat(int year)
        {
            string result = string.Empty;
            int expectedZeroCount = (2 - year.ToString().Length);
            for (int i = 0; i < expectedZeroCount; i++)
            {
                result += "0";
            }
            result += year.ToString();
            return result;
        }
        private static bool CheckIsAllCharactersAreNumber(string value)
        {
            foreach (var character in value)
            {
                if (character < 48 || character > 57)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
