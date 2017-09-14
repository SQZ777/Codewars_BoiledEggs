using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoiledEggs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_0_Should_Be_0()
        {
            //arrange
            var input = 0;
            var expected = 0;
            //act
            var actual = Kata.CookingTime(input);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_1_Should_Be_5()
        {
            //arrange
            var input = 1;
            var expected = 5;
            //act
            var actual = Kata.CookingTime(input);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public static int CookingTime(int input)
        {
            return input * 5;
        }
    }
}
