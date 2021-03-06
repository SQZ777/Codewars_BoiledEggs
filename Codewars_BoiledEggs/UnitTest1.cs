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

        [TestMethod]
        public void Input_5_Should_Be_5()
        {
            cookingTimeResult(5, 5);
        }

        [TestMethod]
        public void Input_10_Should_Be_10()
        {
            cookingTimeResult(10, 10);
        }

        [TestMethod]
        public void Input_11_Should_Be_10()
        {
            cookingTimeResult(10, 11);
        }

        [TestMethod]
        public void Input_8_Should_5()
        {
            cookingTimeResult(5, 8);
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
        public static int CookingTime(int eggs)
        {
            var minutes = 5;
            return CookTimes(eggs) * minutes;
        }

        public static int CookTimes(int eggs)
        {
            var eggsPerPot = 8;
            return (int) Math.Ceiling(Convert.ToDouble(eggs) / eggsPerPot);
        }

       

    }
}
