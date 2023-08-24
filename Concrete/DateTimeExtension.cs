using ConvertExtensionLibrary.Exceptions.DateTimeExtensionExceptions;
using System;
using System.Linq;

namespace ConvertExtensionLibrary.Concrete
{
    public static class DateTimeExtension
    {
        public static DateTime FromJulianDate(this string value)
        {
            int year = string.Join("", value.Take(4)).AsInteger();
            int day = string.Join("", value.Skip(4)).AsInteger();
            if (day > 365)
                throw new DayGreaterThan365Exception();
            if (day < 1)
                throw new DayLessThan1Exception();
            DateTime resultDateTime = new DateTime(year, 1, 1).AddDays((day - 1));
            return resultDateTime;
        }
    }
}
