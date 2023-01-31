using MyUtilities;
public class program
{
    public static void Main(string[] arg)
    {
        string s = Console.ReadLine();
        string a = Console.ReadLine();
        string to_up_result = StringUtils.ToUpper(s);
        string to_low_result = StringUtils.ToLower(s);
        int length_result = StringUtils.Length(s);
        string reverse_result = StringUtils.Reverse(s);
        int vowel_result = StringUtils.CountVowels(s);
        int consonants_result = StringUtils.CountConsonants(s);
        bool letter_result = StringUtils.HasLetter(s, a);
        bool last_letter_result = StringUtils.LastLetterIs(s, a);
        int count_low_result = StringUtils.CountLower(s);
        int count_up_result = StringUtils.CountUpper(s);
        bool is_up_result = StringUtils.IsAllUpper(s);
        Console.WriteLine(is_up_result);
    }
}