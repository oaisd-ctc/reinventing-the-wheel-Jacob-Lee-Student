namespace MyUtilities {
    
    public static class MathUtils {
        
        /// <summary>
        /// Finds the sum of a and b
        /// </summary>
        /// <param name="a"> The first number
        /// <param name="b"> The second number
        /// <returns>
        /// The result of a+b
        /// </returns>
        public static int Add(int a, int b) {
            int x = a + b;
            return x;
        }
        public static float Add(float a, float b) {
            float x = a + b;
            return x;
        }
        public static double Add(double a, double b) {
            double x = a + b;
            return x;
        }

        /// <summary>
        /// Finds the differance of a and b
        /// </summary>
        /// <param name="a"> The first number
        /// <param name="b"> The second number
        /// <returns>
        /// The result of a-b
        /// </returns>
        public static int Subtract(int a, int b) {
            int x = a - b;
            return x;
        }
        public static float Subtract(float a, float b) {
            float x = a - b;
            return x;
        }
        public static double Subtract(double a, double b) {
            double x = a - b;
            return x;
        }

        /// <summary>
        /// Finds the product of a and b
        /// </summary>
        /// <param name="a"> The first number
        /// <param name="b"> The second number
        /// <returns>
        /// The result of a*b
        /// </returns>
        public static int Multiply(int a, int b) {
            int x = a * b;
            return x;
        }
        public static float Multiply(float a, float b) {
            float x = a * b;
            return x;
        }
        public static double Multiply(double a, double b) {
            double x = a * b;
            return x;
        }

        /// <summary>
        /// Finds the quotient of a and b
        /// </summary>
        /// <param name="a"> The dividend
        /// <param name="b"> The divisor
        /// <returns>
        /// The result of a/b
        /// </returns>
        public static int Divide(int a, int b) {
            int x = a / b;
            return x;
        }
        public static float Divide(float a, float b) {
            float x = a / b;
            return x;
        }
        public static double Divide(double a, double b) {
            double x = a / b;
            return x;
        }

        /// <summary>
        /// Finds the smaller number between a and b
        /// </summary>
        /// <param name="a"> The first number
        /// <param name="b"> The second number
        /// <returns>
        /// The smaller number
        /// </returns>
        public static int Min(int a, int b) {
            if (a < b) {
                return a;
            }
            else if (b < a) {
                return b;
            }
            else {
                return a;
            }
        }
        public static float Min(float a, float b) {
            if (a < b) {
                return a;
            }
            else if (b < a) {
                return b;
            }
            else {
                return a;
            }
        }
        public static double Min(double a, double b) {
            if (a < b) {
                return a;
            }
            else if (b < a) {
                return b;
            }
            else {
                return a;
            }
        }

        /// <summary>
        /// Finds the larger number between a and b
        /// </summary>
        /// <param name="a"> The first number
        /// <param name="b"> The second number
        /// <returns>
        /// The larger number
        /// </returns>
        public static int Max(int a, int b) {
            if (a > b) {
                return a;
            }
            else if (b > a) {
                return b;
            }
            else {
                return a;
            }
        }
        public static float Max(float a, float b) {
            if (a > b) {
                return a;
            }
            else if (b > a) {
                return b;
            }
            else {
                return a;
            }
        }
        public static double Max(double a, double b) {
            if (a > b) {
                return a;
            }
            else if (b > a) {
                return b;
            }
            else {
                return a;
            }
        }
        
        /// <summary>
        /// Gives the absolute value of a
        /// </summary>
        /// <param name="a"> The integer
        /// <returns>
        /// Absolute value of a
        /// </returns>
        public static int Abs(int a) {
            if (a < 0) {
                return a *= -1;
            }
            else {
                return a;
            }
        }
        public static float Abs(float a) {
            if (a < 0) {
                return a *= -1;
            }
            else {
                return a;
            }
        }
        public static double Abs(double a) {
            if (a < 0) {
                return a *= -1;
            }
            else {
                return a;
            }
        }
        /// <summary>
        /// Finds the result of a raised to the nth power
        /// </summary>
        /// <param name="a"> The base number
        /// <param name="n"> The exponent
        /// <returns>
        /// The result of the formula a^n
        /// </returns>
        public static int Power(int a, int n) {
            int x = 1;
            if (n > 0) {
                for (int i = 0; i < n; i++) {
                    x *= a;
                }
            }
            else if (n < 0) {
                for (int i = -1; i > n; i--) {
                    x /= a;
                }
            }
            return x;
        }
        public static float Power(float a, float n) {
            float x = 1;
            if (n > 0) {
                for (int i = 0; i < n; i++) {
                    x *= a;
                }
            }
            else if (n < 0) {
                for (int i = -1; i > n; i--) {
                    x /= a;
                }
            }
            return x;
        }
        public static double Power(double a, double n) {
            double x = 1;
            if (n > 0) {
                for (int i = 0; i < n; i++) {
                    x *= a;
                }
            }
            else if (n < 0) {
                for (int i = -1; i > n; i--) {
                    x /= a;
                }
            }
            return x;
        }
        /// <summary>
        /// Finds the square root of a
        /// </summary>
        /// <param name="a"> The base number
        /// <param name="precision"> The decimal point of precision
        /// <returns>
        /// The square root of a
        /// </returns>
        public static double Sqrt(double a, double precision) {
            double x = a;
            while ((x - a / x) > precision) { //loop until reaches precision
                x = (x + a / x) / 2;
            }
            return x;
        }
        public static float Sqrt(float a, float precision) {
            float x = a;
            while ((x - a / x) > precision) { 
                x = (x + a / x) / 2;
            }
            return x;
        }
        public static decimal Sqrt(decimal a, decimal precision) {
            decimal x = a;
            while ((x - a / x) > precision) {
                x = (x + a / x) / 2;
            }
            return x;
        }
        /// <summary>
        /// Doubles a
        /// </summary>
        /// <param name="a"> The base number
        /// <returns>
        /// The result of a*2
        /// </returns>
        public static int Double(int a) {
            int x = a * 2;
            return x;
        }
        public static float Double(float a) {
            float x = a * 2;
            return x;
        }
        public static double Double(double a) {
            double x = a * 2;
            return x;
        }
        /// <summary>
        /// Halves a
        /// </summary>
        /// <param name="a"> The base number
        /// <returns>
        /// The result of a/2
        /// </returns>
        public static int Half(int a) {
            int x = a/2;
            return x;
        }
        public static float Half(float a) {
            float x = a/2;
            return x;
        }
        public static double Half(double a) {
            double x = a/2;
            return x;
        }
        /// <summary>
        /// Finds the remainder of a/2
        /// </summary>
        /// <param name="a"> The dividend
        /// <param name="b"> The divisor
        /// <returns>
        /// The remainder of a/2
        /// </returns>
        public static int Mod(int a, int b) {
            int x = a % b;
            return x;
        }
        public static float Mod(float a, float b) {
            float x = a % b;
            return x;
        }
        public static double Mod(double a, double b) {
            double x = a % b;
            return x;
        }
        /// <summary>
        /// Rounds to the closest whole number via banker's sort
        /// </summary>
        /// <param name="a"> The base number
        /// <returns>
        /// a rounded up
        /// </returns>
        public static int Round(double a) {
            if ((a + 0.5) >= ((int) a + 1)) {
                return ((int) a + 1);
            }
            else {
                return (int)a;
            }
        }
        public static int Round(float a) {
            if ((a + 0.5) >= ((int) a + 1)) {
                return ((int) a + 1);
            }
            else {
                return (int)a;
            }
        }
        public static int Round(long a) {
            if ((a + 0.5) >= ((int) a + 1)) {
                return ((int) a + 1);
            }
            else {
                return (int)a;
            }
        }
    }
}