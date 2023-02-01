namespace MyUtilities
{

    public static class ArrayUtils
    {
        /// <summary>
        /// Finds the Average of the Array
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The average of array a
        /// </returns>

        public static int Average(int[] a)
        {
            int b = a[0] + a[1] + a[2] + a[3];
            b = b / a.Length;
            return b;
        }
        public static int Max(int[] a)
        {
            int x = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[x] > a[i])
                {
                    return a[x];
                }
                else if (a[x] < a[i])
                {
                    x = i;
                }
                else
                {
                    return a[x];
                }
            }
            return a[x];
        }
        public static int Min(int[] a)
        {
            int x = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[x] < a[i])
                {
                    return a[x];
                }
                else if (a[x] > a[i])
                {
                    x = i;
                }
                else
                {
                    return a[x];
                }
            }
            return a[x];
        }
        //public static int SortAscending(int[] a)
        // {
        //     int i = 0;
        //     int n = 4;
        //     for ( i = 0; i < n - 1; i++)
        //         for (int j = 0; j < n - i - 1; j++)
        //             if (a[j] > a[j + 1])
        //             {
        //                 a[i] = a[j];
        //                 a[j] = a[j + 1];
        //                 a[j + 1] = a[i];
        //             }
        //             return a[i];
        // }
        public static int Sum(int[] a)
        {
            int x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                x = x + a[i];
            }
            return x;
        }
        public static int Product(int[] a)
        {
            int x = 1;
            for (int i = 0; i < a.Length; i++)
            {
                x = x * a[i];
            }
            return x;
        }
        public static int[] Reverse(int[] a)
        {
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[(a.Length - 1) - i];
            }
            return arr;
        }

    }
}
