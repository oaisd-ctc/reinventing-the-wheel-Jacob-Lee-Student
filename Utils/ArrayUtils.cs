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
        public static double Average(double[] a)
        {
            double b = a[0] + a[1] + a[2] + a[3];
            b = b / a.Length;
            return b;
        }
        /// <summary>
        /// Finds the Max of the Array
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The max of array a
        /// </returns>
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
        public static double Max(double[] a)
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
        /// <summary>
        /// Finds the Min of the Array
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The min of array a
        /// </returns>
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
        public static double Min(double[] a)
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
        /// <summary>
        /// Finds the Sum of the Array
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The sum of array a
        /// </returns>
        public static int Sum(int[] a)
        {
            int x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                x = x + a[i];
            }
            return x;
        }
        /// <summary>
        /// Finds the Sum of floats of the Array
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The Sum of floats of array a
        /// </returns>
        public static float Sum(float[] a)
        {
            float x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                x = x + a[i];
            }
            return x;
        }
        /// <summary>
        /// Finds the Product of the Array
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The product of array a
        /// </returns>
        public static int Product(int[] a)
        {
            int x = 1;
            for (int i = 0; i < a.Length; i++)
            {
                x = x * a[i];
            }
            return x;
        }
        public static double Product(double[] a)
        {
            double x = 1;
            for (int i = 0; i < a.Length; i++)
            {
                x = x * a[i];
            }
            return x;
        }
        /// <summary>
        /// Finds the reverse of the Array
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The reverse of array a
        /// </returns>
        public static int[] Reverse(int[] a)
        {
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[(a.Length - 1) - i];
            }
            return arr;
        }
        public static double[] Reverse(double[] a)
        {
            double[] arr = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[(a.Length - 1) - i];
            }
            return arr;
        }
        /// <summary>
        /// Clears the Array
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The cleared array
        /// </returns>
        public static int[] Clear(int[] a)
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = 0;
            }
            return b;
        }
        public static double[] Clear(double[] a)
        {
            double[] b = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = 0;
            }
            return b;
        }
        /// <summary>
        /// Clones the Array
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The clone of the array
        /// </returns>
        public static int[] Clone(int[] a)
        {
            int[] clone = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                clone[i] = a[i];
            }
            return clone;
        }
        public static double[] Clone(double[] a)
        {
            double[] clone = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                clone[i] = a[i];
            }
            return clone;
        }
        /// <summary>
        /// Finds the chosen value of the Array
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The chosen value of the array
        /// </returns>
        public static int GetValue(int[] a)
        {
            Console.WriteLine("Pick a number 0 - 3");
            int i = Convert.ToInt32(Console.ReadLine());
            return a[i];
        }
        public static double GetValue(double[] a)
        {
            Console.WriteLine("Pick a number 0 - 3");
            int i = Convert.ToInt32(Console.ReadLine());
            return a[i];
        }
        /// <summary>
        /// Sorts the array in Ascending order
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The Ascending order of array a
        /// </returns>
        public static int[] SortAscending(int[] a)
        {
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[i];
            }
            return arr;
        }
        public static double[] SortAscending(double[] a)
        {
            double[] arr = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[i];
            }
            return arr;
        }
        /// <summary>
        /// Sorts the array in Descending order
        /// </summary>
        /// <array name ="a"> The array
        /// <returns>
        /// The descending order of array a
        /// </returns>
        public static int[] SortDescending(int[] a)
        {
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[(a.Length - 1) - i];
            }
            return arr;
        }
        public static double[] SortDescending(double[] a)
        {
            double[] arr = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[(a.Length - 1) - i];
            }
            return arr;
        }
    }
}