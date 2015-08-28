using NUnit.Framework;
using NUnit.Framework.Constraints;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class StringTests
    {
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void SayHiTest(string name, string expected)
        {
            // arrange
            Strings obj = new Strings();

            // act
            string actual = obj.SayHi(name);

            // assert
            Assert.AreEqual(expected, actual);

            // 

        }

        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void AbbaTest(string a, string b, string expectedResult)
        {
            //arrange 
            Strings obj = new Strings();

            //Act
            string actual = obj.Abba(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTags(string tag, string content, string expectedResult)
        {
            //arrange 
            Strings test = new Strings();

            //Act
            string actual = test.MakeTags(tag, content);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void Insertword(string container, string word, string expectedResult)
        {
            //arrange 
            Strings test = new Strings();

            //Act
            string actual = test.InsertWord(container, word);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndings(string str, string expectedResult)
        {
            //arrange 
            Strings test = new Strings();

            //Act
            string actual = test.MultipleEndings(str);

            //Assert 
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("WooHoo", "Woo")]
        public void FirstHalf(string str, string expectedResult)
        {
            //Arrange
            Strings test = new Strings();

            //Act
            string actual = test.FirstHalf(str);

            //Assert 
            Assert.AreEqual(expectedResult, actual);
        }


        [TestCase("Hello", "ell")]
        public void TrimOne(string str, string expectedResult)
        {
            //Arrange
            Strings test = new Strings();

            //Act
            string actual = test.TrimOne(str);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("Hi", "Hello", "HiHelloHi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddle(string a, string b, string expectedResult)
        {
            //Arrange 
            Strings test = new Strings();

            //act
            string actual = test.LongInMiddle(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void Rotateleft2(string str, string expectedResult)
        {
            //arrange 
            Strings test = new Strings();

            //Act
            string actual = test.Rotateleft2(str);

            //Assert 
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateRight2(string str, string expectedResult)
        {
            //arrange 
            Strings test = new Strings();

            //Act
            string actual = test.RotateRight2(str);

            //Assert 
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase(("Hello"), true, "H")]
        [TestCase(("Hello"), false, "o")]
        [TestCase(("oh"), true, "o")]
        [TestCase((""), false, "")]
        public void TakeOne(string str, bool fromFront, string expectedResult)
        {
            //arrange 
            Strings test = new Strings();

            //Act
            string actual = test.TakeOne(str, fromFront);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("string", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]
        public void MiddleTwo(string str, string expectedResult)
        {
            //arrange : get your target class 
            Strings test = new Strings();

            //Act : call the method 
            string actual = test.MiddleTwo(str);

            //Assert : assess target 
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]
        public void EndsWithLy(string str, bool expectedResult)
        {
            //arrange: get your target class 
            Strings test = new Strings();

            //Act : call the method you want to test 
            bool actual = test.EndsWithLy(str);

            //Assert: assess target 
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void FrontAndBack(string str, int n, string expectedResult)
        {
            //arrange 
            Strings test = new Strings();

            //Act
            string actual = test.FrontAndBack(str, n);

            //assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void TakeTwoFromPosition(string str, int n, string expectedResult)
        {
            //arrange: get your target class 
            Strings test = new Strings();

            //Act: Call the method 
            string actual = test.TakeTwoFromPosition(str, n);

            //Assert 
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]
        public void HasBad(string str, bool expectedResult)
        {
            //Arrange: get your target 
            Strings test = new Strings();

            //Act: Call the method 
            bool actual = test.HasBad(str);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("hello", "he")]
        [TestCase("hi", "hi")]
        [TestCase("h", "h@")]
        public void AtFirst(string str, string expectedResult)
        {
            //Arrange: get your target 
            Strings test = new Strings();

            //Act: Call the method 
            string actual = test.AtFirst(str);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        public void Concat(string a, string b, string expectedResult)
        {
            //Arrange: get your target class
            Strings test = new Strings();

            //Act: Call the method
            string actual = test.Concat(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("coding", "codign")]
        [TestCase("cat", "cta")]
        [TestCase("ab", "ba")]
        public void swaplast(string a, string expectedResult)
        {
            //Arrange: get your target class
            Strings test = new Strings();

            //Act: Call the method
            string actual = test.SwapLast(a);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]
        public void FrontAgain(string str, bool expectedResult)
        {
            //Arrange: get my target class
            Strings test = new Strings();

            //Act: call the method 
            bool answer = test.FrontAgain(str);

            //Assert 
            Assert.AreEqual(expectedResult, answer);
        }

        [TestCase("Hello", "Hi", "loHi")]
        [TestCase("Hello", "java", "ellojava")]
        [TestCase("java", "Hello", "javaello")]
        public void MinCat(string a, string b, string expectedResult)
        {
            //Arrange: get my target class
            Strings test = new Strings();

            //Act: call the method 
            string answer = test.MinCat(a, b);

            //Assert 
            Assert.AreEqual(expectedResult, answer);
        }

        [TestCase("Hello", "llo")]
        [TestCase("away", "aay")]
        [TestCase("abed", "abed")]
        public void TweakFront(string str, string expectedResult)
        {
            //Arrange: get my target class
            Strings test = new Strings();

            //Act: call the method 
            string answer = test.TweakFront(str);

            //Assert 
            Assert.AreEqual(expectedResult, answer);
        }

        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]
        public void stripX(string str, string expectedResult)
        {
            //Arrange: get my target class
            Strings test = new Strings();

            //Act: call the method 
            string answer = test.StripX(str);

            //Assert 
            Assert.AreEqual(expectedResult, answer);

        }
    }
}
