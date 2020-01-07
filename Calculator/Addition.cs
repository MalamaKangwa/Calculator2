using System;

namespace Calculator2
{
    public class Addition
    {
        public static int Sum (int a, int b)
        {
            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Sum(double[] arrayA)
        {
            double c = 0.0;

            foreach (double a in arrayA) 
            {
                c = Sum(a, c);
            }
            return c;
        }

        public static int Sum(int[] arrayB)
        {
            int d = 0;

            foreach (int a in arrayB)
            {
                d = Sum(a, d);
            }
            return d;
        }

    }
}
