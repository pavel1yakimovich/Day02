using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task01.Newthon;

namespace Task01.Tests
{
    [TestClass]
    public class NewthonTests
    {
        [TestMethod]
        public void Newthon_n26power4eps0_01_return2_2581()
        {
            //Arrange
            int n = 4;
            double A = 26, eps = 0.01;
            double expected = 2.2581;

            //Act
            double result = NewthonMethod(eps, n, A);

            //Assert
            Assert.IsTrue(Math.Abs(expected - result) < eps);
        }

        [TestMethod]
        public void Newthon_n26_765power3eps0_01_return2_9625()
        {
            //Arrange
            int n = 3;
            double A = 26.765, eps = 0.01;
            double expected = 2.9913;

            //Act
            double result = NewthonMethod(eps, n, A);

            //Assert
            Assert.IsTrue(Math.Abs(expected - result) < eps);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void Newthon_n26_765power4epsMinus0_01_returnArithmeticException()
        {
            //Arrange
            int n = 4;
            double A = 26.765, eps = -0.01;

            //Act
            double result = NewthonMethod(eps, n, A);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void Newthon_n26_765power4eps1_2_returnArithmeticException()
        {
            //Arrange
            int n = 4;
            double A = 26.765, eps = 1.2;

            //Act
            double result = NewthonMethod(eps, n, A);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void Newthon_n26_765powerMinus4eps0_01_returnArithmeticException()
        {
            //Arrange
            int n = -4;
            double A = 26.765, eps = 0.01;

            //Act
            double result = NewthonMethod(eps, n, A);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void Newthon_nMinus26_765power4eps0_01_returnArithmeticException()
        {
            //Arrange
            int n = 4;
            double A = -26.765, eps = 0.01;

            //Act
            double result = NewthonMethod(eps, n, A);
        }

        [TestMethod]
        public void Newthon_nMinus26_765power3eps0_01_returnMinus2_9913()
        {
            //Arrange
            int n = 3;
            double A = -26.765, eps = 0.01, expected = -2.9913;

            //Act
            double result = NewthonMethod(eps, n, A);

            //Assert
            Assert.IsTrue(Math.Abs(result - expected) < eps);
        }

    }
}
