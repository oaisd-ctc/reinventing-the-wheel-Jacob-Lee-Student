using Xunit;
namespace MyUtilities;

public class Tests
{
    [Fact]
    public void ToUpperTest()
    {
        string aTest = ("Hello");
        string desiredOutcome = ("HELLO");
        Assert.Equal(desiredOutcome, StringUtils.ToUpper(aTest));
    }
    [Fact]
    public void ToLowerTest()
    {
        string aTest = ("Hello");
        string desiredOutcome = ("hello");
        Assert.Equal(desiredOutcome, StringUtils.ToLower(aTest));
    }
    [Fact]
    public void LengthTest()
    {
        string aTest = ("BANANA");
        int desiredOutcome = 6;
        Assert.Equal(desiredOutcome, StringUtils.Length(aTest));
    }
    [Fact]
    public void ReverseTest()
    {
        string aTest = ("BANANA");
        string desiredOutcome = ("ANANAB");
        Assert.Equal(desiredOutcome, StringUtils.Reverse(aTest));
    }
    [Fact]
    public void CountVowelsTest()
    {
        string aTest = ("BANANA");
        int desiredOutcome = 3;
        Assert.Equal(desiredOutcome, StringUtils.CountVowels(aTest));
    }
    [Fact]
    public void CountConsonantsTest()
    {
        string aTest = ("BANANA");
        int desiredOutcome = 3;
        Assert.Equal(desiredOutcome, StringUtils.CountConsonants(aTest));
    }
    [Fact]
    public void HasLetterTest()
    {
        string aTest = ("BANANA");
        string bTest = ("o");
        bool desiredOutcome = false;
        Assert.Equal(desiredOutcome, StringUtils.HasLetter(aTest, bTest));
    }
    [Fact]
    public void LastLetterIsTest()
    {
        string aTest = ("BANANA");
        string bTest = ("o");
        bool desiredOutcome = false;
        Assert.Equal(desiredOutcome, StringUtils.LastLetterIs(aTest, bTest));
    }
    [Fact]
    public void CountLowerTest()
    {
        string aTest = ("BANANA");
        int desiredOutcome = 0;
        Assert.Equal(desiredOutcome, StringUtils.CountLower(aTest));
    }
    [Fact]
    public void CountUpperTest()
    {
        string aTest = ("BANANA");
        int desiredOutcome = 6;
        Assert.Equal(desiredOutcome, StringUtils.CountUpper(aTest));
    }
    [Fact]
    public void IsAllUpperTest()
    {
        string aTest = ("BANANA");
        bool desiredOutcome = true;
        Assert.Equal(desiredOutcome, StringUtils.IsAllUpper(aTest));
    }
}