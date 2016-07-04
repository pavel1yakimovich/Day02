using System;
using NUnit.Framework;
using System.Collections.Generic;
using static Task02.Euclidean;

namespace Task02.NUnitTests
{
    [TestFixture]
    public class EuclideanTests
    {
        public IEnumerable<TestCaseData> TestData
        {
            get
            {
                yield return new TestCaseData(42, 18).Returns(6);
                yield return new TestCaseData(-42, 18).Returns(6);
                yield return new TestCaseData(42, -18).Returns(6);
                yield return new TestCaseData(-42, -18).Returns(6);
                yield return new TestCaseData(42, 0).Returns(42);
                yield return new TestCaseData(-42, 0).Returns(42);
                yield return new TestCaseData(42, 1).Returns(1);
                yield return new TestCaseData(-42, 1).Returns(1);
                yield return new TestCaseData(42, -1).Returns(1);
                yield return new TestCaseData(-42, -1).Returns(1);
                yield return new TestCaseData(42, 42).Returns(42);
                yield return new TestCaseData(-42, 42).Returns(42);
                yield return new TestCaseData(-42, -42).Returns(42);
                yield return new TestCaseData(42, 2147483647).Returns(1);
                yield return new TestCaseData(-42, 2147483647).Returns(1);
                yield return new TestCaseData(42, -2147483647).Returns(1);
                yield return new TestCaseData(-42, -2147483647).Returns(1);
                yield return new TestCaseData(18, 42).Returns(6);
                yield return new TestCaseData(18, -42).Returns(6);
                yield return new TestCaseData(-18, 42).Returns(6);
                yield return new TestCaseData(-18, -42).Returns(6);
                yield return new TestCaseData(0, 42).Returns(42);
                yield return new TestCaseData(0, -42).Returns(42);
                yield return new TestCaseData(1, 42).Returns(1);
                yield return new TestCaseData(1, -42).Returns(1);
                yield return new TestCaseData(-1, 42).Returns(1);
                yield return new TestCaseData(-1, -42).Returns(1);
                yield return new TestCaseData(42, -42).Returns(42);
                yield return new TestCaseData(2147483647, 42).Returns(1);
                yield return new TestCaseData(2147483647, -42).Returns(1);
                yield return new TestCaseData(-2147483647, 42).Returns(1);
                yield return new TestCaseData(-2147483647, -42).Returns(1);
                yield return new TestCaseData(0, 0).Throws(typeof(ArgumentException));
            }
        }

        public IEnumerable<TestCaseData> TestData3Args
        {
            get
            {
                yield return new TestCaseData(42, 18, 6).Returns(6);
                yield return new TestCaseData(42, 0, 6).Returns(6);
                yield return new TestCaseData(42, -42, 42).Returns(42);
                yield return new TestCaseData(42, 2147483647, 1).Returns(1);
            }
        }

        [Test, TestCaseSource(nameof(TestData))]
        public int EuclideanAlgorithhm_2ArgsWithYield(int a, int b)
        {
            return EuclideanAlgorithm(a, b);
        }

        [Test, TestCaseSource(nameof(TestData))]
        public int GCD_2ArgsWithYield(int a, int b)
        {
            return GCD(a, b);
        }

        [Test, TestCaseSource(nameof(TestData3Args))]
        public int EuclideanAlgorithhm_3ArgsWithYield(int a, int b, int c)
        {
            return EuclideanAlgorithm(a, b, c);
        }

        [Test, TestCaseSource(nameof(TestData3Args))]
        public int GCD_3ArgsWithYield(int a, int b, int c)
        {
            return GCD(a, b, c);
        }

        [TestCase(42, 18, 6, 2, Result = 2)]
        [TestCase(42, 0, 6, 0, 2, Result = 2)]
        [TestCase(42, -42, 42, 0, 21, 126, Result = 21)]
        [TestCase(42, 2147483647, 1, 0, 245, -677, Result = 1)]
        public int EuclideanAlgorithm_MoreArgsWithYield(params int[] a)
        {
            return EuclideanAlgorithm(a);
        }

        [TestCase(42, 18, 6, 2, Result = 2)]
        [TestCase(42, 0, 6, 0, 2, Result = 2)]
        [TestCase(42, -42, 42, 0, 21, 126, Result = 21)]
        [TestCase(42, 2147483647, 1, 0, 245, -677, Result = 1)]
        public int GCD_MoreArgsWithYield(params int[] a)
        {
            return GCD(a);
        }
    }
}
