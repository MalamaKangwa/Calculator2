using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator2
{
    public class Division
    {

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double Divide(double[] arrayA)
        {
            double c = arrayA[0];

            foreach (double a in arrayA)
            {
                c = Divide(c, a);
            }
            double d = c * arrayA[0];
            return d;
        }

        public static int Divide(int[] arrayB)
        {
            int d = arrayB[0];

            for (int i = 1; i < arrayB.Length; i++)
            {
                d = Divide(d, arrayB[i]);
            }
            return d;
        }

    }
}
