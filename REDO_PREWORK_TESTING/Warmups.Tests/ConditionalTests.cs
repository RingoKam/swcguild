using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class ConditionalTests
    {
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTroubleTest(bool aSmile, bool bSmile, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.AreWeInTrouble(aSmile, bSmile);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void CanSleepIn(bool isWeekday, bool isVacation, bool expected)
        {
            //Arrange 
            Conditionals test = new Conditionals ();

            //Act 
            bool actual = test.CanSleepIn(isWeekday, isVacation);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDouble(int a, int b, int expected)
        {
            //Arrange 
            Conditionals test = new Conditionals();

            //Act 
            int actual = test.SumDouble(a,b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(23,4)]
        [TestCase(10,11)]
        [TestCase(21, 0)]
        public void Diff21test(int a, int expected)
        {
            //Arrange 
            Conditionals test = new Conditionals();

            //Act 
            int actual = test.Diff21(a);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTroubletest(bool isTalking, int hour, bool expected)
        {
            Conditionals test = new Conditionals();
            bool actual = test.ParrotTrouble(isTalking, hour);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 10, true)]
        [TestCase(9, 9 , false)]
        [TestCase(1, 9, true)]
        public void Makes10(int a, int b, bool expected)
        {
            Conditionals test = new Conditionals();
            bool actual = test.Makes10(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]
        public void NearHundred(int a, bool expected)
        {
            Conditionals test = new Conditionals();
            bool actual = test.NearHundred(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void NotStringtest(string s, string expected)
        {
            Conditionals test = new Conditionals();
            string actual = test.NotString(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]
        public void MissingChar(string str, int n, string expected)
        {
            Conditionals test = new Conditionals();
            string actual = test.MissingChar(str, n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("code","eodc")]
        [TestCase("a","a")]
        [TestCase("ab","ba")]
        public void FrontBackTest(string str, string expected)
        {
            Conditionals test = new Conditionals();
            string actual = test.FrontBack(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]
        public void front3test(string str, string expected)
        {
            Conditionals test = new Conditionals();
            string actual = test.Front3(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void BackAroundTest(string str, string expected)
        {
            Conditionals test = new Conditionals();
            string actual = test.BackAround(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]
        public void multiple3or5test(int number, bool expected)
        {
            Conditionals test = new Conditionals();
            bool actual = test.Multiple3or5(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("hi there", true)]
        [TestCase("hi ", true)]
        [TestCase("high up", true)]
        public void StartHitest(string str, bool expected)
        {
            Conditionals test = new Conditionals();
            bool actual = test.StartHi(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]
        public void IcyHottest(int temp1, int temp2, bool expected)
        {
            Conditionals test = new Conditionals();
            bool actual = test.IcyHot(temp1, temp2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        public void Between10and20test(int a, int b, bool expected)
        {
            Conditionals test = new Conditionals();
            bool actual = test.Between10and20(a, b); 
            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]
        public void HasTeenTest(int a, int b, int c, bool expected)
        {
            Conditionals test = new Conditionals();
            bool actual = test.HasTeen(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        public void SoAloneTest(int a, int b, bool expected)
        {
            Conditionals test = new Conditionals();
            bool actual = test.SoAlone(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]
        public void removeDelTest(string str, string expected)
        {
            Conditionals test = new Conditionals();
            string actual = test.RemoveDel(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        public void IxStart(string str, bool expected)
        {
            Conditionals test = new Conditionals();
            bool actual = test.IxStart(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]
        public void StartOzTest(string str, string expected)
        {
            Conditionals test = new Conditionals();
            string actual = test.StartOz(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]
        public void MaxTest(int a, int b, int c, int expected)
        {
            Conditionals test = new Conditionals();
            int actual = test.Max(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]
        public void CloserTest(int a, int b, int expected)
        {
            Conditionals test = new Conditionals();
            int actual = test.Closer(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]
        public void GotE(string str, bool expected)
        {
            Conditionals test = new Conditionals();
            bool actual = test.GotE(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]
        public void EndUpTest(string str, string expected)
        {
            Conditionals test = new Conditionals();
            string actual = test.EndUp(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        public void EveryNthtest(string str, int n, string expected)
        {
            Conditionals test = new Conditionals();
            string actual = test.EveryNth(str, n);
            Assert.AreEqual(expected, actual);
        }

    }
}
