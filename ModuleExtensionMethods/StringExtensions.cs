namespace ModuleExtensionMethods
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberofwords)
        {
            if (numberofwords <= 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0.");
            if (numberofwords == 0)
                return "";
            var words = str.Split(' ');

            if (words.Length <= numberofwords)
                return str;

            return string.Join(" ",words.Take(numberofwords));
        
        }
    }
}