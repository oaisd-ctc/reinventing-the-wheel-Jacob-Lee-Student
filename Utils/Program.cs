using MyUtilities;
public class program
{
    public static void Main(string[] arg)
    {
        string s = Console.ReadLine();
        string a = Console.ReadLine();
        string up_result = StringUtils.ToUpper(s);
        string low_result = StringUtils.ToLower(s);
        int length_result = StringUtils.Length(s);
        string reverse_result = StringUtils.Reverse(s, length_result);
        int vowel_result = StringUtils.CountVowels(up_result);
        int consonants_result = StringUtils.CountConsonants(up_result);
        bool letters_result = StringUtils.HasLetter(up_result, a);
        Console.WriteLine(reverse_result);
    }
}