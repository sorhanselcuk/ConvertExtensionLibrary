namespace ConvertExtensionLibrary.Exceptions.DateTimeExtensionExceptions
{
    public class DayGreaterThan365Exception : JulianDateException
    {
        private const string ExceptionMessage = "Julian Date Format for day not should be greater than 365.";
        public DayGreaterThan365Exception() : base(ExceptionMessage)
        {

        }
    }
}
