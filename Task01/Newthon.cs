using System;

namespace Task01
{
    public static class Newthon
    {
        static double f(double x, int n, double A)
        {
            double t = x;
            for(int i = 0; i < n - 1; i++)
            {
                x *= t;
            }
            return x - A;
        }

        static double df(double x, int n)
        {
            double t = x;
            for (int i = 0; i < n - 2; i++)
            {
                x *= t;
            }
            return x*n;
        }

        public static double NewthonMethod(int a, int b, double eps, int n, double A)
        {
            double x0;
            if (f(a, n, A) * df(a, n) > 0) x0 = a;
            else x0 = b;

            double xk = x0 - f(x0, n, A) / df(x0, n);
            while(Math.Abs(x0 - xk) > eps)
            {
                x0 = xk;
                xk = x0 - f(x0, n, A) / df(x0, n);
            }
            return xk;
        }
    }
}
