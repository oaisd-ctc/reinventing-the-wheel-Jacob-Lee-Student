using Xunit;
namespace MyUtilities;
public class ArrayTests
{
    [Fact]
    public void AverageTest()
    {
        int[] a = { 5, 15, 20, 30 };
        int desiredOutcome = 17;
        Assert.Equal(desiredOutcome, ArrayUtils.Average(a));
    }
    [Fact]
    public void Max()
    {
        int[] a = { 5, 15, 20, 30 };
        int desiredOutcome = 30;
        Assert.Equal(desiredOutcome, ArrayUtils.Max(a));
    }
    [Fact]
    public void Min()
    {
        int[] a = { 5, 15, 20, 30 };
        int desiredOutcome = 5;
        Assert.Equal(desiredOutcome, ArrayUtils.Min(a));
    }
    [Fact]
    public void Sum()
    {
        int[] a = { 5, 15, 20, 30 };
        int desiredOutcome = 70;
        Assert.Equal(desiredOutcome, ArrayUtils.Sum(a));
    }
    [Fact]
    public void Product()
    {
        int[] a = { 5, 15, 20, 30 };
        int desiredOutcome = 45000;
        Assert.Equal(desiredOutcome, ArrayUtils.Product(a));
    }
    [Fact]
    public void Reverse()
    {
        int[] a = { 5, 15, 20, 30 };
        int[] desiredOutcome = {30, 20, 15, 5};
        Assert.Equal(desiredOutcome, ArrayUtils.Reverse(a));
    }
    [Fact]
    public void Clear()
    {
        int[] a = { 5, 15, 20, 30 };
        int[] desiredOutcome = { 0, 0, 0, 0 };
        Assert.Equal(desiredOutcome, ArrayUtils.Clear(a));
    }
    [Fact]
    public void Clone()
    {
        int[] a = { 5, 15, 20, 30 };
        int[] desiredOutcome = {5, 15, 20, 30};
        Assert.Equal(desiredOutcome, ArrayUtils.Clone(a));
    }
    [Fact]
    public void SortAscending()
    {
        int[] a = { 5, 15, 20, 30 };
        int[] desiredOutcome = { 5, 15, 20, 30 };
        Assert.Equal(desiredOutcome, ArrayUtils.SortAscending(a));
    }
    [Fact]
    public void SortDescending()
    {
        int[] a = { 5, 15, 20, 30 };
        int[] desiredOutcome = { 30, 30, 15, 5 };
        Assert.Equal(desiredOutcome, ArrayUtils.SortDescending(a));
    }
}