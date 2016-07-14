using System;
using System.Diagnostics;

namespace Task02
{
    public static class Euclidean
    {
        /// <summary>
        /// cheks signs of parametrs for EuclideanAlgorithm and GCD
        /// </summary>
        /// <param name="a">1st parametr</param>
        /// <param name="b">2nd parametr</param>
        public static void CheckSign(ref int a, ref int b)
        {
            if (a < 0)
            {
                if (b < 0)
                {
                    a = -a;
                    b = -b;
                }
                else
                {
                    a = -a;
                }
            }
            else
            {
                if (b < 0)
                {
                    b = -b;
                }
            }
        }

        /// <summary>
        /// Euclidean algorithm for 2 arguments
        /// </summary>
        /// <param name="a">1st parametr</param>
        /// <param name="b">2nd parametr</param>
        /// <returns>gcd</returns>
        public static int EuclideanAlgorithm(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                CheckSign(ref a, ref b);
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
                while (a >= b)
                {
                    a -= b;
                }
                if (a == 0) return b;
                else return EuclideanAlgorithm(b, a);
            }          
        }

        /// <summary>
        /// Binary Euclidean algorithm for 2 arguments
        /// </summary>
        /// <param name="a">1st parametr</param>
        /// <param name="b">2nd parametr</param>
        /// <returns>gcd</returns>
        public static int BinaryEuclideanAlgorithm(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                CheckSign(ref a, ref b);
                if (a == b)
                    return Math.Abs(a);
                if (a == 0)
                    return b;
                if (b == 0)
                    return a;
                if (a % 2 == 0)
                {
                    if (b % 2 == 0)
                    {
                        return 2 * BinaryEuclideanAlgorithm(a / 2, b / 2);
                    }
                    else return BinaryEuclideanAlgorithm(a / 2, b);
                }
                else
                {
                    if (b % 2 == 0)
                    {
                        return BinaryEuclideanAlgorithm(a, b / 2);
                    }
                    else
                    {
                        if (a > b) return BinaryEuclideanAlgorithm((a - b) / 2, b);
                        else return BinaryEuclideanAlgorithm(a, (b - a) / 2);
                    }
                }
            }
        }

        public static int GCD(int a, int b, TypeOfAlgorithmDelegate algorithmDelegate)
        {
            return algorithmDelegate(a, b);
        }

        public static int GCD(int a, int b, out long ticks, TypeOfAlgorithmDelegate algorithmDelegate)
        {
            Stopwatch time = Stopwatch.StartNew();
            int t = algorithmDelegate(a, b);
            time.Stop();
            ticks = time.ElapsedTicks;
            return t;
        }

        public static int GCD(int a, int b, int c, TypeOfAlgorithmDelegate algorithmDelegate)
        {
            int t = algorithmDelegate(a, b);
            t = algorithmDelegate(t, c);
            return t;
        }

        public static int GCD(int a, int b, int c, out long ticks, TypeOfAlgorithmDelegate algorithmDelegate)
        {
            Stopwatch time = Stopwatch.StartNew();
            int t = algorithmDelegate(a, b);
            t = algorithmDelegate(t, c);
            time.Stop();
            ticks = time.ElapsedTicks;
            return t;
        }
        
        public static int GCD(TypeOfAlgorithmDelegate algorithmDelegate, params int[] array)
        {
            int t = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                t = algorithmDelegate(t, array[i]);
            }
            return t;
        }
       
        public static int GCD(out long ticks, TypeOfAlgorithmDelegate algorithmDelegate, params int[] array)
        {
            Stopwatch time = Stopwatch.StartNew();
            int t = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                t = algorithmDelegate(t, array[i]);
            }
            time.Stop();
            ticks = time.ElapsedTicks;
            return t;
        }
    }
}
