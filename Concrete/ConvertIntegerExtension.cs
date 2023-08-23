using System;

namespace ConvertExtensionLibrary.Concrete
{
    public static class ConvertIntegerExtension
    {
        public static string AsString(this int value)
        {
            return value.ToString();
        }
        public static long AsLong(this int value)
        {
            return Convert.ToInt64(value);
        }
    }
}
