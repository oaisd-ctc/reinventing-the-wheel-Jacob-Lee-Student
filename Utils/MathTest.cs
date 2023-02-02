/* using Xunit;
namespace MyUtilities;

public class MathTests {
    [Fact]
    public void AddTest() { 
        int aTest = 2;
        int bTest = 3;
        int desiredOutcome = 5;
        Assert.Equal(desiredOutcome, MathUtils.Add(aTest, bTest));
    }
    [Fact]
    public void SubTest() {
        int aTest = 3;
        int bTest = 1;
        int desiredOutcome = 2;
        Assert.Equal(desiredOutcome, MathUtils.Subtract(aTest, bTest));
    }
    [Fact]
    public void MultiTest() {
        int aTest = 2;
        int bTest = 5;
        int desiredOutcome = 10;
        Assert.Equal(desiredOutcome, MathUtils.Multiply(aTest, bTest));
    }
    [Fact]
    public void DivTest() {
        int aTest = 10;
        int bTest = 2;
        int desiredOutcome = 5;
        Assert.Equal(desiredOutcome, MathUtils.Divide(aTest, bTest));
    }
    [Fact]
    public void MinTest() {
        int aTest = 10;
        int bTest = 2;
        int desiredOutcome = 2;
        Assert.Equal(desiredOutcome, MathUtils.Min(aTest, bTest));
    }
    [Fact]
    public void MaxTest() {
        int aTest = 10;
        int bTest = 10;
        int desiredOutcome = 10;
        Assert.Equal(desiredOutcome, MathUtils.Max(aTest, bTest));
    }
    [Fact]
    public void AbsTest() {
        int aTest = -10;
        int desiredOutcome = 10;
        Assert.Equal(desiredOutcome, MathUtils.Abs(aTest));
    }
    [Fact]
    public void PowTest() {
        double aTest = 5;
        double nTest = 2;
        double desiredOutcome = 25;
        Assert.Equal(desiredOutcome, MathUtils.Power(aTest, nTest));
    }
    [Fact]
    public void SqrtTest() {
        double aTest = 5;
        double precision = 0.0000000000000001;
        double desiredOutcome = 2;
        Assert.Equal(desiredOutcome, Math.Round(MathUtils.Sqrt(aTest, precision)));
    }
    [Fact]
    public void DoubleTest() {
        int aTest = 15;
        int desiredOutcome = 30;
        Assert.Equal(desiredOutcome, MathUtils.Double(aTest));
    }
    [Fact]
    public void HalfTest() {
        int aTest = 100;
        int desiredOutcome = 50;
        Assert.Equal(desiredOutcome, MathUtils.Half(aTest));
    }
    [Fact]
    public void ModTest() {
        int aTest = 5;
        int bTest = 2;
        int desiredOutcome = 1;
        Assert.Equal(desiredOutcome, MathUtils.Mod(aTest, bTest)); 
    }
    [Fact]
    public void RoundTest() {
        double aTest = 1.3;
        int desiredOutcome = 1;
        Assert.Equal(desiredOutcome, MathUtils.Round(aTest));
    }
}
