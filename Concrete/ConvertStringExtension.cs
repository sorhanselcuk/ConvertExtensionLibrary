using System;

namespace ConvertExtensionLibrary.Concrete
{
    public static class ConvertStringExtension
    {
        public static int AsInteger(this string value)
        {
            return Convert.ToInt32(value);
        }
        public static long AsLong(this string value)
        { 
            return Convert.ToInt64(value); 
        }
        public static DateTime AsDateTime(this string value)
        {
            return Convert.ToDateTime(value);
        }
    }
}
