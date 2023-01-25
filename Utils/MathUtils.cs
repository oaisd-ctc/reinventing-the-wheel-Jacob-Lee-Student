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
        
    }
}