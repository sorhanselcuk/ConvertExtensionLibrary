using ConvertExtensionLibrary.Exceptions.DateTimeExtensionExceptions;
using System;
using System.Linq;

namespace ConvertExtensionLibrary.Concrete
{
    public static class DateTimeExtension
    {
        public static DateTime FromJulianDate(this string value)
        {
            if (value.Length < 6)
                throw new IncorrectJulianFormatException("Julian date format should be minimum 6 character.");
            if (!CheckIsAllCharactersAreNumber(value))
                throw new IncorrectJulianFormatException("All characters are should be number.");
            string reverseValue = string.Join("",value.Reverse());
            int dayValue = string.Join("", reverseValue.Take(3)).AsInteger();
            int yearValue = string.Join("",reverseValue.Skip(3).Take(2)).AsInteger();
            int centuryValue = string.Join("", reverseValue.Skip(5)).AsInteger();
            if (dayValue > 366)
                throw new DayGreaterThan366Exception();
            if (yearValue < 1)
                throw new DayLessThan1Exception();
            int year = ((19 + centuryValue) * 100) + yearValue;

            DateTime resultDateTime = new DateTime(year, 1, 1).AddDays((dayValue - 1));
            return resultDateTime;
        }

        private static bool CheckIsAllCharactersAreNumber(string value)
        {
            foreach(var character in value)
            {
                if(character < 48 || character > 57)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
