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
        /// Euclidean algorithm for 2 arguments. Also shows the time
        /// </summary>
        /// <param name="a">1st parametr</param>
        /// <param name="b">2nd parametr</param>
        /// <param name="ticks">number of ticks for this algorithm</param>
        /// <returns>gcd</returns>
        public static int EuclideanAlgorithm(int a, int b, out long ticks)
        {
            Stopwatch time = Stopwatch.StartNew();
            int t = EuclideanAlgorithm(a, b);
            time.Stop();
            ticks = time.ElapsedTicks;
            return t;
        }
        /// <summary>
        /// Euclidean algorithm for 3 arguments
        /// </summary>
        /// <param name="a">1st parametr</param>
        /// <param name="b">2nd parametr</param>
        /// <param name="c">3d parametr</param>
        /// <returns>gcd</returns>
        public static int EuclideanAlgorithm(int a, int b, int c)
        {
            int t = EuclideanAlgorithm(a, b);
            t = EuclideanAlgorithm(t, c);
            return t;
        }
        /// <summary>
        /// Euclidean algorithm for 3 arguments. Also shows the time
        /// </summary>
        /// <param name="a">1st parametr</param>
        /// <param name="b">2nd parametr</param>
        /// <param name="c">3d parametr</param>
        /// <param name="ticks">number of ticks for this algorithm</param>
        /// <returns>gcd</returns>
        public static int EuclideanAlgorithm(int a, int b, int c, out long ticks)
        {
            Stopwatch time = Stopwatch.StartNew();
            int t = EuclideanAlgorithm(a, b);
            t = EuclideanAlgorithm(t, c);
            time.Stop();
            ticks = time.ElapsedTicks;
            return t;
        }
        /// <summary>
        /// Euclidean algorithm for >3 arguments.
        /// </summary>
        /// <param name="array">arguments</param>
        /// <returns>gcd</returns>
        public static int EuclideanAlgorithm(params int [] array)
        {
            int t = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                t = EuclideanAlgorithm(t, array[i]);
            }
            return t;
        }
        /// <summary>
        /// Euclidean algorithm for 3 arguments. Also shows the time
        /// </summary>
        /// <param name="ticks">>number of ticks for this algorithm</param>
        /// <param name="array">parametrs</param>
        /// <returns></returns>
        public static int EuclideanAlgorithm(out long ticks, params int[] array)
        {
            Stopwatch time = Stopwatch.StartNew();
            int t = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                t = EuclideanAlgorithm(t, array[i]);
            }
            ticks = time.ElapsedTicks;
            return t;
        }
        /// <summary>
        /// Binary Euclidean algorithm for 2 arguments
        /// </summary>
        /// <param name="a">1st parametr</param>
        /// <param name="b">2nd parametr</param>
        /// <returns>gcd</returns>
        public static int GCD(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                CheckSign(ref a, ref b);
                if (a == 0)
                    return b;
                if (b == 0)
                    return a;
                if (a % 2 == 0)
                {
                    if (b % 2 == 0)
                    {
                        return 2 * GCD(a / 2, b / 2);
                    }
                    else return GCD(a / 2, b);
                }
                else
                {
                    if (b % 2 == 0)
                    {
                        return GCD(a, b / 2);
                    }
                    else
                    {
                        if (a > b) return GCD((a - b) / 2, b);
                        else return GCD(a, (b - a) / 2);
                    }
                }
            }
        }
        /// <summary>
        /// Binary Euclidean algorithm for 2 arguments. Also shows the time
        /// </summary>
        /// <param name="a">1st parametr</param>
        /// <param name="b">2nd parametr</param>
        /// <param name="ticks">number of ticks for this algorithm</param>
        /// <returns>gcd</returns>
        public static int GCD(int a, int b, out long ticks)
        {
            Stopwatch time = Stopwatch.StartNew();
            int t = GCD(a, b);
            time.Stop();
            ticks = time.ElapsedTicks;
            return t;
        }
        /// <summary>
        /// Binary Euclidean algorithm for 3 arguments
        /// </summary>
        /// <param name="a">1st parametr</param>
        /// <param name="b">2nd parametr</param>
        /// <param name="c">3d parametr</param>
        /// <returns>gcd</returns>
        public static int GCD(int a, int b, int c)
        {
            int t = GCD(a, b);
            t = GCD(t, c);
            return t;
        }
        /// <summary>
        /// Binary Euclidean algorithm for 3 arguments. Also shows the time
        /// </summary>
        /// <param name="a">1st parametr</param>
        /// <param name="b">2nd parametr</param>
        /// <param name="c">3d parametr</param>
        /// <param name="ticks">number of ticks for this algorithm</param>
        /// <returns>gcd</returns>
        public static int GCD(int a, int b, int c, out long ticks)
        {
            Stopwatch time = Stopwatch.StartNew();
            int t = GCD(a, b);
            t = GCD(t, c);
            time.Stop();
            ticks = time.ElapsedTicks;
            return t;
        }
        /// <summary>
        /// Binary Euclidean algorithm for >3 arguments.
        /// </summary>
        /// <param name="array">arguments</param>
        /// <returns>gcd</returns>
        public static int GCD(params int[] array)
        {
            int t = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                t = GCD(t, array[i]);
            }
            return t;
        }
        /// <summary>
        /// Binary Euclidean algorithm for 3 arguments. Also shows the time
        /// </summary>
        /// <param name="ticks">>number of ticks for this algorithm</param>
        /// <param name="array">parametrs</param>
        /// <returns></returns>
        public static int GCD(out long ticks, params int[] array)
        {
            Stopwatch time = Stopwatch.StartNew();
            int t = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                t = GCD(t, array[i]);
            }
            time.Stop();
            ticks = time.ElapsedTicks;
            return t;
        }
    }
}
