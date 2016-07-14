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
                yield return new TestCaseData(42, 18, new TypeOfAlgorithmDelegate(EuclideanAlgorithm)).Returns(6);
                yield return new TestCaseData(-42, 18, new TypeOfAlgorithmDelegate(EuclideanAlgorithm)).Returns(6);
                yield return new TestCaseData(42, 42, new TypeOfAlgorithmDelegate(EuclideanAlgorithm)).Returns(42);
                yield return new TestCaseData(42, 2147483647, new TypeOfAlgorithmDelegate(EuclideanAlgorithm)).Returns(1);
                yield return new TestCaseData(-42, 2147483647, new TypeOfAlgorithmDelegate(BinaryEuclideanAlgorithm)).Returns(1);
                yield return new TestCaseData(42, -42, new TypeOfAlgorithmDelegate(BinaryEuclideanAlgorithm)).Returns(42);
                yield return new TestCaseData(2147483647, 42, new TypeOfAlgorithmDelegate(BinaryEuclideanAlgorithm)).Returns(1);
                yield return new TestCaseData(0, 0, new TypeOfAlgorithmDelegate(BinaryEuclideanAlgorithm)).Throws(typeof(ArgumentException));
            }
        }

        public IEnumerable<TestCaseData> TestData3Args
        {
            get
            {
                yield return new TestCaseData(42, 18, 6, new TypeOfAlgorithmDelegate(EuclideanAlgorithm)).Returns(6);
                yield return new TestCaseData(42, 0, 6, new TypeOfAlgorithmDelegate(EuclideanAlgorithm)).Returns(6);
                yield return new TestCaseData(42, -42, 42, new TypeOfAlgorithmDelegate(BinaryEuclideanAlgorithm)).Returns(42);
                yield return new TestCaseData(42, 2147483647, 1, new TypeOfAlgorithmDelegate(BinaryEuclideanAlgorithm)).Returns(1);
            }
        }

        public IEnumerable<TestCaseData> TestDataMoreArgs
        {
            get
            {
                yield return new TestCaseData(new TypeOfAlgorithmDelegate(EuclideanAlgorithm), 42, 18, 6, 2).Returns(2);
                yield return new TestCaseData(new TypeOfAlgorithmDelegate(EuclideanAlgorithm), 42, 0, 6, 0, 2).Returns(2);
                yield return new TestCaseData(new TypeOfAlgorithmDelegate(BinaryEuclideanAlgorithm), 42, -42, 42, 0, 21, 126).Returns(21);
                yield return new TestCaseData(new TypeOfAlgorithmDelegate(BinaryEuclideanAlgorithm), 42, 2147483647, 1, 0, 245, -677).Returns(1);
            }
        }

        [Test, TestCaseSource(nameof(TestData))]
        public int GCD_2ArgsWithYield(int a, int b, TypeOfAlgorithmDelegate algorithmDelegate)
        {
            return GCD(a, b, algorithmDelegate);
        }

        [Test, TestCaseSource(nameof(TestData3Args))]
        public int GCD_3ArgsWithYield(int a, int b, int c, TypeOfAlgorithmDelegate algorithmDelegate)
        {
            return GCD(a, b, c, algorithmDelegate);
        }

        [Test, TestCaseSource(nameof(TestDataMoreArgs))]
        public int GCD_MoreArgsWithYield(TypeOfAlgorithmDelegate algorithmDelegate, params int[] a)
        {
            return GCD(algorithmDelegate, a);
        }
    }
}
