namespace ConvertExtensionLibrary.Exceptions.DateTimeExtensionExceptions
{
    public class DayGreaterThan366Exception : JulianDateException
    {
        private const string ExceptionMessage = "Julian Date Format for day not should be greater than 366.";
        public DayGreaterThan366Exception() : base(ExceptionMessage)
        {

        }
    }
}
