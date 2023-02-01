using MyUtilities;
public class Program
{
    public static void Main(string[] arg)
    {
        int[] a = { 5, 15, 20, 30 };
        int resultAver = ArrayUtils.Average(a);
        Console.WriteLine("The Average is: " + resultAver);

        int resultMax = ArrayUtils.Max(a);
        Console.WriteLine("The Max is: " + resultMax);

        int resultMin = ArrayUtils.Min(a);
        Console.WriteLine("The Min is: " + resultMin);

        // int resultSortA = ArrayUtils.SortAscending(a);
        // Console.WriteLine(resultSortA);

        int resultSum = ArrayUtils.Sum(a);
        Console.WriteLine("The Sum is: " + resultSum);

        int resultProd = ArrayUtils.Product(a);
        Console.WriteLine("The Product is: " + resultProd);
        
        int [] resultRev = ArrayUtils.Reverse(a);
        Console.Write("The array in Reverse is: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(resultRev[i] + " ");
        }
        Console.WriteLine();
    }
}