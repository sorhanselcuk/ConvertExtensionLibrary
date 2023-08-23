﻿using System;
using System.Linq;

namespace ConvertExtensionLibrary.Concrete
{
    public static class DateTimeExtension
    {
        public static DateTime FromJulianDate(this string value)
        {
            int year = string.Join("",value.Take(4)).AsInteger();
            int day = string.Join("", value.Skip(4)).AsInteger();
            DateTime resultDateTime = new DateTime(year,0,0);
            resultDateTime.AddDays(day);
            return resultDateTime;
        }
    }
}
