namespace LinkedIn.Essentials
{
    static class Constants
    {
        private static string connectionString;
        public static readonly string CONFIG_SERVER_NAME = "TargetServer";
        public const string CONFIG_DB_NAME = "DatabaseName";

        public static int MyProperty { get; set; }
        public static DateTime GetDateTimeFromDateOnly(DateOnly input)
        {
            return new DateTime(input.Year, input.Month, input.Day);
        }
        static Constants()
        {
            connectionString = "Server=..."; //config
        }
    }
}
