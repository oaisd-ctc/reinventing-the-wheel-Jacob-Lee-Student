namespace MyUtilities
{
    public static class StringUtils
    {
        public static string ToUpper(string s)
        {
            string text = ("");
            foreach (char c in s)
            {
                int i = (int)(c);
                if (c >= 97 && c <= 122)
                {
                    int unicode = c - 32;
                    char character = (char)unicode;
                    text = text + character;
                }
                else
                {
                    int unicode = c;
                    char character = (char)unicode;
                    text = text + character;
                }
            }
            return text;
        }
        public static string ToLower(string s)
        {
            string text = ("");
            foreach (char c in s)
            {
                int i = (int)(c);
                if (c >= 65 && c <= 90)
                {
                    int unicode = c + 32;
                    char character = (char)unicode;
                    text = text + character;
                }
                else
                {
                    int unicode = c;
                    char character = (char)unicode;
                    text = text + character;
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
            string reversestring=("");
            while (length_result >= 0)
            {
                reversestring = reversestring + s[length_result];
                length_result--;
            }
            return reversestring;
        }
        public static int CountVowels(string upresult)
        {
            int i = 0;
            foreach (char c in upresult)
            {
                int a = (int)(c);
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
                int a = (int)(c);
                if (c != 65 || c != 69 || c != 73 || c != 79 || c != 85)
                {
                    i = i + 1;
                }
            }
            return i;
        }
        /* public static bool HasLetter(string up_result, string a)
        {
            int d = 0;
            int e = 0;
            bool answer = false;
            foreach (char b in a)
            {
                e = (int)(b);
                if (e >= 91)
                {
                    e = e - 32;
                }
            }
            foreach (char c in up_result)
            {
                d = (int)(c);
                if (d == e)
                {
                    answer = true;
                }
            }
            return answer;
        } */
    }
}