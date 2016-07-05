using System;
using NUnit.Framework;
using static Task01.Newthon;

namespace Task01.NUnitTests
{
    public class NewthonNUnitTests
    {
        [TestCase(0.01, 4, 26.765, 2.2745)]
        [TestCase(0.01, 3, 26.765, 2.9913)]
        [TestCase(0.01, 3, -26.765, -2.9913)]
        public void NewthonMethod_Test(double eps, int n, double A, double res)
        {
            Assert.IsTrue(Math.Abs(res - NewthonMethod(eps, n, A)) < eps);
        }

        [TestCase(1.2, 3, 26.765)]
        [TestCase(0.01, -4, 26.765)]
        [TestCase(0.01, 4, -26.765)]
        [TestCase(-0.01, 3, -26.765)]
        public void NewthinMethod_ArithmeticException(double eps, int n, double A)
        {
            Assert.Throws<ArithmeticException>(() => NewthonMethod(eps, n, A));
        }
    }
}
