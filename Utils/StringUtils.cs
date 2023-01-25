namespace MyUtilities
{
    public static class StringUtils
    {
        public static string ToUpper(string s)
        {
            string s = Console.ReadLine();
            foreach (char c in s)
            {
                System.Convert.ToInt32(c);
                int unicode = c - 32;
                char character = (char)unicode;
                string text = character.ToString();
                Console.WriteLine(text);
            }
        }
        public static string ToLower(string s)
        {

        }
        public static string length(string s)
        {

        }
    }
}