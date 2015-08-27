using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class LoopTests
    {
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimesTest(string str, int n, string expected)
        {
            // arrange
            Loops obj = new Loops();

            // act
            string actual = obj.StringTimes(str, n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void FrontTimesTest(string str, int n, string expected)
        {
            //Arrange 
            Loops test = new Loops();
            //Act
            string actual = test.FrontTimes(str, n);
            //Assert 
            Assert.AreEqual(expected,actual);
        }

        [TestCase("abcxx",1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXXTest(string str, int expected)
        {
            //Arrange
            Loops test = new Loops();
            //Act
            int actual = test.countXX(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void DoubleXtest(string str, bool expected)
        {
            //Arrange
            Loops test = new Loops();
            //Act
            bool actual = test.DoubleX(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOther(string str, string expected)
        {
            //Arrange
            Loops test = new Loops();
            //Act
            string actual = test.EveryOther(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void stringSplosion(string str, string expected)
        {
            //Arrange 
            Loops test = new Loops();
            //Act
            string actual = test.StringSplosion(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2test(string str, int expected)
        {
            //Arrange 
            Loops test = new Loops();
            //Act
            int actual = test.CountLast2(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 9}, 1)]
        [TestCase(new int[] {1, 9, 9}, 2)]
        [TestCase(new int[] {1, 9, 9, 3, 9}, 3)]
        public void count9test(int[] numbers, int expected)
        {
            //Arrange 
            Loops test = new Loops();
            //Act
            int actual = test.Count9(numbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 9, 3, 4}, true)]
        [TestCase(new int[] {1, 2, 3, 4, 9}, false)]
        [TestCase(new int[] {1, 2, 3}, false)]
        [TestCase(new int[] {1, 2, 3, 4, 5}, false)]
        public void arrayfront9test(int[] numbers, bool expected)
        {
            //Arrange 
            Loops test = new Loops();
            //Act
            bool actual = test.ArrayFront9(numbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1,1,2,3,1}, true)]
        [TestCase(new int[] {1,1,2,4,1}, false)]
        [TestCase(new int[] {1,1,2,1,2,3}, true)]
        public void Array123test(int[] numbers, bool expected)
        {
            //Arrange 
            Loops test = new Loops();
            //Act
            bool actual = test.Array123(numbers);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //SubStringMatch
        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]
        public void SubstringMatchTest(string a, string b, int expected)
        {
            //Arrange 
            Loops test = new Loops();
            //Act
            int actual = test.SubStringMatch(a,b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        //StringX
        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]
        public void StringX(string str, string expected)
        {
            //Arrange 
            Loops test = new Loops();
            //Act
            string actual = test.StringX(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        public void Altpairstest(string str, string expected)
        {
            //Arrange 
            Loops test = new Loops();
            //Act
            string actual = test.AltPairs(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void DoNotYak(string str, string expected)
        {
            //Arrange 
            Loops test = new Loops();
            //Act
            string actual = test.DoNotYak(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Array667({ 6, 6, 2}) -> 1
        //Array667({ 6, 6, 2, 6}) -> 1
        //Array667({ 6, 7, 2, 6}) -> 1
        [TestCase(new int[] {6, 6, 2}, 1)]
        [TestCase(new int[] {6, 6, 2, 6}, 1)]
        [TestCase(new int[] {6, 7, 2, 6}, 1)]
        public void Array667(int[] numbers, int expected)
        {
            //Arrange 
            Loops test = new Loops();
            //Act
            int actual = test.Array667(numbers);
            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 7, 1}, true)]
        [TestCase(new int[] {1, 2, 8, 1}, false)]
        [TestCase(new int[] {2, 7, 1}, true)]
        public void Pattern51test(int[] numbers, bool expected)
        {
            //Arrange 
            Loops test =  new Loops();

            //Act
            bool actual = test.Pattern51(numbers);

            //Assert 
            Assert.AreEqual(expected, actual);
        }



    }
}
