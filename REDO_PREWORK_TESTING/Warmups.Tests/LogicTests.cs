﻿using NUnit.Framework;
using NUnit.Framework.Constraints;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class LogicTests
    {
        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]
        public void GreatPartyTest(int cigars, bool isWeekend, bool expected)
        {
            // arrange
            Logic obj = new Logic();

            // act
            bool actual = obj.GreatParty(cigars, isWeekend);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 10, 2)]
        [TestCase(5, 2, 0)]
        [TestCase(5, 5, 1)]
        public void CanHazTableTest(int yourStyle, int dateStyle, int expected)
        {
            Logic test =  new Logic();
            int actual = test.CanHazTable(yourStyle, dateStyle);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true, true)]
        public void PlayOutsideTest(int temp, bool isSummer, bool expected)
        {
            Logic test = new Logic();
            bool actual = test.PlayOutside(temp, isSummer);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]
        public void CaughtSpeeding(int speed, bool isBirthDay, int expected)
        {
            Logic test = new Logic();
            int actual = test.CaughtSpeeding(speed, isBirthDay);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4, 7)]
        [TestCase(9, 4, 20)]
        [TestCase(10, 11, 21)]
        public void skipSumTest(int a, int b, int expected)
        {
            Logic test = new Logic();
            int actual = test.skipSum(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, false, "7:00")]
        [TestCase(5, false, "7:00")]
        [TestCase(0, false, "10:00")]
        public void AlarmClock(int day, bool vacation, string expected)
        {
            Logic test = new Logic();
            string actual = test.AlarmClock(day, vacation);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 4, true)]
        [TestCase(5, 4, false)]
        [TestCase(1, 5, true)]
        public void LoveSixTest(int a, int b, bool expected)
        {
            Logic test = new Logic();
            bool actual = test.LoveSix(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, false, true)]
        [TestCase(11, false, false)]
        [TestCase(5, false, true)]
        public void InRange(int n, bool OutsideMode, bool expected)
        {
            Logic test = new Logic();
            bool actual = test.InRange(n, OutsideMode);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(22, true)]
        [TestCase(23, true)]
        [TestCase(24, false)]
        public void SpecialEleven(int n,bool expected )
        {
            Logic test = new Logic();
            bool actual = test.SpecialEleven(n); 
            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, false)]
        [TestCase(21, true)]
        [TestCase(22, true)]
        public void Mod20(int n, bool expected)
        {
            Logic test = new Logic();
            bool actual = test.Mod20(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(15, false)]
        public void Mod35test(int n, bool expected)
        {
            Logic test = new Logic();
            bool actual = test.Mod35(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(true, false, false, false)]
        public void AnswerCell(bool isMorning, bool isMom, bool isAsleep, bool expected)
        {
            Logic test = new Logic();
            bool actual = test.AnswerCell(isMorning, isMom, isAsleep);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, true)]
        [TestCase(3, 1, 2, true)]
        [TestCase(3, 2, 2, false)]
        public void TwoIsOneTest(int a, int b, int c, bool expected)
        {
            Logic test = new Logic();
            bool actual = test.TwoIsOne(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 4, false, true)]
        [TestCase(1, 2, 1, false, false)]
        [TestCase(1, 1, 2, true, true)]
        public void AreInOrderTest(int a, int b, int c, bool bok, bool expected)
        {
            Logic test = new Logic();
            bool actual = test.AreInOrder(a, b, c, bok);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, 11, false, true)]
        [TestCase(5, 7, 6, false, false)]
        [TestCase(5, 5, 7, true, true)]
        public void InOrderEqualtest(int a, int b, int c, bool equalok, bool expected)
        {
            Logic test = new Logic();
            bool actual = test.InOrderEqual(a, b, c, equalok);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(23, 19, 13, true)]
        [TestCase(23, 19, 12, false)]
        [TestCase(23, 19, 3, true)]
        public void LastDigitTest(int a, int b, int c, bool expected )
        {
            Logic test = new Logic();
            bool actual = test.LastDigit(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, true, 5)]
        [TestCase(3, 3, true, 7)]
        [TestCase(3, 3, false, 6)]
        public void RollDiceTest(int die1, int die2, bool noDoubles, int expected)
        {
            Logic test = new Logic();
            int actual = test.RollDice(die1, die2, noDoubles);
            Assert.AreEqual(expected, actual);
        }





    }
}
