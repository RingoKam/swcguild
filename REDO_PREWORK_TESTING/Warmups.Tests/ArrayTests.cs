using System;
using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class ArrayTests
    {
        [TestCase(new int[] { 1, 2, 6}, true)]
        [TestCase(new int[] { 6, 1, 2, 3 }, true)]
        [TestCase(new int[] { 13, 6, 1, 2, 3 }, false)]
        public void FirstLast6Test(int[] numbers, bool expected)
        {
            // arrange
            Arrays obj = new Arrays();

            // act
            bool actual = obj.FirstLast6(numbers);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3}, false)]
        [TestCase(new int[] { 1, 2, 3, 1}, true)]
        [TestCase(new int[] { 1, 2, 1}, true)]
        public void SameFirstLastTest(int[] numbers, bool expected)
        {
            Arrays test = new Arrays();
            bool actual = test.SameFirstLast(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] {3, 1, 4})]
        public void MakePiTest(int n, int[] expected)
        {
            Arrays test = new Arrays();
            int[] actual = test.MakePi(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {7, 3}, true)]
        [TestCase(new int[] {1, 2, 3}, new int[] {7, 3, 2}, false)]
        [TestCase(new int[] {1, 2, 3}, new int[] {1, 3}, true)]
        public void commonEndTest(int[] a, int[] b, bool expected)
        {
            Arrays test = new Arrays();
            bool actual = test.CommonEnd(a,b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1,2,3}, 6)]
        [TestCase(new int[] { 5, 11, 2 }, 18)]
        [TestCase(new int[] { 7, 0, 0 }, 7)]
        public void Sum(int[] numbers, int expected)
        {
            Arrays test = new Arrays();
            int actual = test.sum(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {2, 3, 1})]
        [TestCase(new int[] {1, 2, 3}, new int[] {2, 3, 1})]
        [TestCase(new int[] {1, 2, 3}, new int[] {2, 3, 1})]
        public void rotateLeftTest(int[] numbers, int[] expected)
        {
            Arrays test = new Arrays();
            int[] actual = test.RotateLeft(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {3, 2, 1})]
        public void reverseTest(int[] numbers, int[] expected)
        {
            Arrays test = new Arrays();
            int[] actual = test.Reverse(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {3, 3, 3})]
        [TestCase(new int[] {11, 5, 9}, new int[] {11, 11, 11})]
        [TestCase(new int[] {2, 11, 3}, new int[] {3, 3, 3})]
        public void HigherwinsTest(int[] numbers, int[] expected)
        {
            Arrays test = new Arrays();
            int[] actual = test.HigherWins(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1,2,3}, new int[] {4,5,6}, new int[] {2,5})]
        [TestCase(new int[] { 7, 7, 7 }, new int[] { 3, 8, 0 }, new int[] { 7, 8})]
        [TestCase(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }, new int[] { 2, 4})]
        public void GetMiddle(int[] a, int[] b, int[] expected)
        {
            Arrays test = new Arrays();
            int[] actual = test.GetMiddle(a,b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {4, 5, 6}, new int[] {0, 0, 0, 0, 0, 6})]
        [TestCase(new int[] {1, 2}, new int[] {0, 0, 0, 2})]
        [TestCase(new int[] {3}, new int[] {0, 3})]
        public void KeepLastTest(int[] numbers, int[] expected)
        {
            Arrays test = new Arrays();
            int[] actual = test.KeepLast(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2,2,3}, true)]
        [TestCase(new int[] { 3,4,5,3 }, true)]
        [TestCase(new int[] { 2, 3, 2, 2 }, false)]
        public void Double23Test(int[] numbers, bool expected)
        {
            Arrays test = new Arrays();
            bool actual = test.Double23(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 3}, new int[] {1, 2, 0})]
        [TestCase(new int[] {2, 3, 5}, new int[] {2, 0, 5})]
        [TestCase(new int[] {1, 2, 1}, new int[] {1, 2, 1})]
        public void Fix23test(int[] numbers, int[] expected)
        {
            Arrays test = new Arrays();
            int[] actual = test.Fix23(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 3, 4, 5}, true)]
        [TestCase(new int[] {2, 1, 3, 4, 5}, true)]
        [TestCase(new int[] {1, 1, 1}, false)]
        public void Unlucky1test(int[] numbers, bool expected)
        {
            Arrays test = new Arrays();
            bool actual = test.Unlucky1(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {4, 5}, new int[] {1, 2, 3}, new int[] {4, 5})]
        [TestCase(new int[] {4}, new int[] {1, 2, 3}, new int[] {4, 1})]
        [TestCase(new int[] {}, new int[] {1, 2}, new int[] {1, 2})]
        public void make2test(int[] a, int[] b, int[] expected)
        {
            Arrays test = new Arrays();
            int[] actual = test.make2(a,b);
            Assert.AreEqual(expected, actual);
        }





    }
}
