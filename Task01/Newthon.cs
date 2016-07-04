using System;

namespace Task02
{
    public static class Newthon
    {
        public static double NewthonMethod(double eps, int n, double A)
        {
            double n0 = 0;
            double nk = 1;

            if (A <= 0 && n % 2 != 0)
            {
                throw new ArithmeticException();
            }
            if (n == 0)
            {
                throw new ArithmeticException();
            }

            while (Math.Abs(nk - n0) >= eps)
            {
                n0 = nk;
                nk = (1 / n)*((n - 1)*n0 + A/Math.Pow(n0, n - 1));
            }
            return nk;
        }
    }
}
