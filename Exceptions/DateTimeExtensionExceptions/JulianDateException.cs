using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertExtensionLibrary.Exceptions.DateTimeExtensionExceptions
{
    public class JulianDateException : Exception
    {
        public JulianDateException(string message):base(message)
        {
        }
    }
}
