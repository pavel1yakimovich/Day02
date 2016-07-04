using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task02.Euclidean;

namespace Task02.Tests
{
    [TestClass]
    public class EuclideanTests
    {
        [TestMethod]
        public void Newthon_42and18_6return()
        {
            //Arrange
            int a = 42, b = 18, expected = 6;

            //Act
            int result = EuclideanAlgorithm(a, b);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Newthon_18and42_6return()
        {
            //Arrange
            int a = 18, b = 42, expected = 6;

            //Act
            int result = EuclideanAlgorithm(a, b);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
