namespace MyUtilities
{
    public static class StringUtils
    {
        public static string ToUpper(string s)
        {
            string text = ("");
            foreach (char c in s)
            {
                //make it numbers
                int i = (int)(c);
                //check if the ASCII would be lower or upper case and makes sure its actualy a letter
                if (c >= 97 && c <= 122)
                {
                    //it is lowercase so removeing 32 makes it uppercase
                    int unicode = c - 32;
                    //make it text
                    char character = (char)unicode;
                    text = text + character;
                }
                else
                {
                    //leaves it uppercase
                    int unicode = c;
                    //make it text
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
                //make it numbers
                int i = (int)(c);
                //check if the ASCII would be lower or upper case and makes sure its actualy a letter
                if (c >= 65 && c <= 90)
                {
                    //it is uppercase so adding 32 makes it lowercase
                    int unicode = c + 32;
                    //make it text
                    char character = (char)unicode;
                    text = text + character;
                }
                else
                {
                    //leaves it lowercase
                    int unicode = c;
                    //make it text
                    char character = (char)unicode;
                    text = text + character;
                }
            }
            return text;
        }
        public static int Length(string s)
        {
            //idk what to say it just counts the letters
            int i = 0;
            foreach (char c in s)
            {
                i++;
            }
            return i;
        }
        public static string Reverse(string s)
        {
            //I don't understand how I did this but it works
            string reversed = "";
            int length = StringUtils.Length(s) - 1;

            while (length >= 0)
            {
                reversed = reversed + s[length];
                length--;
            }
            return reversed;
        }
        public static int CountVowels(string s)
        {
            //uses upppercase so I don't have to check 10 numbers
            s=StringUtils.ToUpper(s);
            int i = 0;
            foreach (char c in s)
            {
                //upper case comes in letters so I change it back into numbers
                int a = (int)(c);
                //A=65 E=69 I=73 O=79 U=85
                if (c == 65 || c == 69 || c == 73 || c == 79 || c == 85)
                {
                    //counts the number of AEIOU
                    i = i + 1;
                }
            }
            return i;
        }
        public static int CountConsonants(string s)
        {
            //uses upppercase so I don't have to check 10 numbers
            s=StringUtils.ToUpper(s);
            int i=StringUtils.Length(s);
            foreach (char c in s)
            {
                //upper case comes in letters so I change it back into numbers
                int a = (int)(c);
                //A=65 E=69 I=73 O=79 U=85
                if (c == 65 || c == 69 || c == 73 || c == 79 || c == 85)
                {
                    //subtracts anything that is AEIOU
                    i = i - 1;
                }
            }
            return i;
        }
        public static bool HasLetter(string s, string a)
        {
            int d = 0;
            int e = 0;
            s=StringUtils.ToUpper(s);
            //set it to false because it might not have the letter
            bool answer = false;
            //This is always the number we compare. There is no reason to change it and I cant directly change string to int but I can with char. I could probably do this simpler but idk how
            foreach (char b in a)
            {
                //make it numbers
                e = (int)(b);
                if (e >= 97 && e <= 122)
                {
                    //make it uppercase
                    e = e - 32;
                }
            }
            foreach (char c in s)
            {
                //upper case comes in letters so I change it back into numbers
                d = (int)(c);
                if (d == e)
                {
                    //I dont allow it to change back to false
                    answer = true;
                }
            }
            return answer;
        }
        public static bool LastLetterIs(string s, string a)
        {
            int d = 0;
            int e = 0;
            s=StringUtils.ToUpper(s);
            //set it to false because it might not have the letter
            bool answer = false;
            //This is always the number we compare. There is no reason to change it and I cant directly change string to int but I can with char. I could probably do this simpler but idk how
            foreach (char b in a)
            {
                //make it numbers
                e = (int)(b);
                if (e >= 97 && e <= 122)
                {
                    e = e - 32;
                }
            }
            foreach (char c in s)
            {
                //upper case comes in letters so I change it back into numbers
                d = (int)(c);
                if (d == e)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            return answer;
        }
        public static int CountLower(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                int i = (int)(c);
                //make it numbers
                if (c >= 97 && c <= 122)
                {
                    count = count + 1;
                }
            }
            return count;
        }
        public static int CountUpper(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                int i = (int)(c);
                //make it numbers
                if (c >= 65 && c <= 90)
                {
                    count = count + 1;
                }
            }
            return count;
        }
        public static bool IsAllUpper(string s)
        {
            bool answer = false;
            foreach (char c in s)
            {
                if (c >= 65 && c <= 90)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                    return answer;
                }
            }
            return answer;
        }
    }
}