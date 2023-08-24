namespace ConvertExtensionLibrary.Exceptions.DateTimeExtensionExceptions
{
    public class DayLessThan1Exception:JulianDateException
    {
        private const string ExceptionMessage = "Julian Date Format for day not should be less than 1.";
        public DayLessThan1Exception() : base(ExceptionMessage)
        {
               
        }
    }
}
