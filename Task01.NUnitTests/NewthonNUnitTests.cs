using System;
using NUnit.Framework;
using static Task01.Newthon;

namespace Task01.NUnitTests
{
    public class NewthonNUnitTests
    {
        [TestCase(0.01, 4, 26.765, 2.2745, Result = true)]
        public bool NewthonMethod_Test(double eps, int n, double A, double res)
        {
            if (Math.Abs(NewthonMethod(eps, n, A) - res) < eps) return true;
            else return false;
        }
    }
}
