using System;
using System.Diagnostics;

namespace Task02
{
    public class Euclidean
    {
        public static Stopwatch time;
        public static int EuclideanAlgorithmRecursion(int a, int b)
        {
            if (b > a)
            {
                int t = a;
                a = b;
                b = t;
            }
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            while(a >= b)
            {
                a -= b;
            }
            if (a == 0) return b;
            else return EuclideanAlgorithmRecursion(b, a);           
        }
        public static int EuclideanAlgorithm(int a, int b)
        {
            time = Stopwatch.StartNew();
            int t = EuclideanAlgorithmRecursion(a, b);
            time.Stop();
            return t;
        }
        public static int EuclideanAlgorithm(params int [] array)
        {
            time = Stopwatch.StartNew();
            int t = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                t = EuclideanAlgorithmRecursion(t, array[i]);
            }
            time.Stop();
            return t;
        }
        public static int GCDRecursion(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if (a % 2 == 0)
            {
                if (b % 2 == 0)
                {
                    return 2 * GCDRecursion(a / 2, b / 2);
                }
                else return GCDRecursion(a / 2, b);
            }
            else
            {
                if (b % 2 == 0)
                {
                    return GCDRecursion(a, b / 2);
                }
                else
                {
                    if (a > b) return GCDRecursion((a - b) / 2, b);
                    else return GCDRecursion(a, (b - a) / 2);
                }
            }
        }
        public static int GCD(int a, int b)
        {
            time = Stopwatch.StartNew();
            int t = GCDRecursion(a, b);
            time.Stop();
            return t;
        }
        public static int GCD(params int[] array)
        {
            time = Stopwatch.StartNew();
            int t = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                t = GCDRecursion(t, array[i]);
            }
            time.Stop();
            return t;
        }
    }
}
