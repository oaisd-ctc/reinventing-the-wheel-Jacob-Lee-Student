namespace MyUtilities
{
    public static class StringUtils
    {
        public static string ToUpper(string s)
        {
            string text = ("");
            foreach (char c in s)
            {
                System.Convert.ToInt32(c);
                if (c >= 97 && c <= 122)
                {
                    int unicode = c - 32;
                    char character = (char)unicode;
                    string ASCII = character.ToString();
                    text = text + ASCII;
                }
                else
                {
                    int unicode = c;
                    char character = (char)unicode;
                    string ASCII = character.ToString();
                    text = text + ASCII;
                }
            }
            return text;
        }
        public static string ToLower(string s)
        {
            string text = ("");
            foreach (char c in s)
            {
                System.Convert.ToInt32(c);
                if (c >= 65 && c <= 90)
                {
                    int unicode = c + 32;
                    char character = (char)unicode;
                    string ASCII = character.ToString();
                    text = text + ASCII;
                }
                else
                {
                    int unicode = c;
                    char character = (char)unicode;
                    string ASCII = character.ToString();
                    text = text + ASCII;
                }
            }
            return text;
        }
        public static int Length(string s)
        {
            int i = 0;
            foreach (char c in s)
            {
                i++;
            }
            return i;
        }
        public static string Reverse(string s, int length_result)
        {
            for (int i= 0; i>=length_result; i--)
            {

            }
            return s;
        }
        public static int CountVowels(string upresult)
        {
            int i = 0;
            foreach (char c in upresult)
            {
                System.Convert.ToInt32(c);
                if (c == 65 || c == 69 || c == 73 || c == 79 || c == 85)
                {
                    i = i + 1;
                }
            }
            return i;
        }
        public static int CountConsonants(string upresult)
        {
            int i = 0;
            foreach (char c in upresult)
            {
                System.Convert.ToInt32(c);
                if (c != 65 || c != 69 || c != 73 || c != 79 || c != 85)
                {
                    i = i + 1;
                }
            }
            return i;
        }
        public static bool HasLetter(string s)
        {
            bool answer = true;
            return answer;
        }
    }
}