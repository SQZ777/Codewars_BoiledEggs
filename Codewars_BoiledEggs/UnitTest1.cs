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
            cookingTimeResult(0, 0);
        }

        [TestMethod]
        public void Input_1_Should_Be_5()
        {
            cookingTimeResult(5, 1);
        }

        [TestMethod]
        public void Input_2_Should_Be_5()
        {
            cookingTimeResult(5, 2);
        }

        private static void cookingTimeResult(int expected, int input)
        {
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
            var result = 0;
            var ceilNum = Math.Ceiling(Convert.ToDouble(input) / 5);
            result = (int)ceilNum * 5;
            return result;
        }

    }
}
