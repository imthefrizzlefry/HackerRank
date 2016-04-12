using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirtyDayClasses;
using System.Collections.Generic;

namespace ThirtyDayTests
{
    [TestClass]
    public class DailyTests
    {
        #region 00 Hello World
        [TestMethod]
        [TestCategory("Day00HelloWorld")]
        public void HelloWorldTest1()
        {
            string testString = " Welcome to 30 Days of Code!";
            string expectedOutput = "Hello, World." + testString;

            string actualOutput = ThirtyDayClasses.Day00HelloWorld.Hello(testString);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Day00HelloWorld")]
        public void HelloWorldTest2()
        {
            string testString = " HackerRank is the best!";
            string expectedOutput = "Hello, World." + testString;

            string actualOutput = ThirtyDayClasses.Day00HelloWorld.Hello(testString);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
        
        #endregion

        #region 01 Data Types
        [TestMethod]
        [TestCategory("Day01DataTypes")]
        public void DataTypeTest1()
        {
            List<String> testInput = new List<String> {
                "12",
                "4.0",
                "is the best place to learn and practice coding!"};

            List<String> expectedOutput = new List<String> {
                "16",
                "8.0",
                "HackerRank is the best place to learn and practice coding!" };

            List<String> actualOutput = ThirtyDayClasses.Day01DataTypes.DataTypes(testInput);

            Assert.AreEqual(expectedOutput[0], actualOutput[0], "The Integer is wrong");
            Assert.AreEqual(expectedOutput[1], actualOutput[1], "The Double is wrong");
            Assert.AreEqual(expectedOutput[2], actualOutput[2], "The String is wrong");

        }
        #endregion

        #region 02 Operators
        [TestMethod]
        [TestCategory("Day02Operators")]
        public void OperatorsTest1()
        {
            List<String> testInput = new List<String> {
                "12.00",
                "20",
                "8"};

            String expectedOutput = "The total meal cost is 15 dollars.";

            String actualOutput = ThirtyDayClasses.Day02Operators.MealTotal(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);

        }

        [TestMethod]
        [TestCategory("Day02Operators")]
        public void OperatorsTest2()
        {
            List<String> testInput = new List<String> {
                "15.50",
                "15",
                "10"};

            String expectedOutput = "The total meal cost is 19 dollars.";

            String actualOutput = ThirtyDayClasses.Day02Operators.MealTotal(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);

        }

        #endregion

        

        #region 08 Dictionaries and Maps
        [TestMethod]
        [TestCategory("Day08DictionariesAndMaps")]
        public void DictionariesAndMaps1()
        {
            List<String> testInput = new List<String> {
                "3",
                "sam 99912222",
                "tom 11122222",
                "harry 12299933",
                "sam",
                "edward",
                "harry"};

            List<String> expectedOutput = new List<String> {
                "sam=99912222",
                "Not found",
                "harry=12299933" };

            List<String> actualOutput = ThirtyDayClasses.Day08DictionariesAndMaps.Dictionary(testInput);

            Assert.AreEqual(expectedOutput[0], actualOutput[0], "Sam Is Wrong");
            Assert.AreEqual(expectedOutput[1], actualOutput[1], "Edward is wrong");
            Assert.AreEqual(expectedOutput[2], actualOutput[2], "Harry is wrong");

        }

        [TestMethod]
        [TestCategory("Day08DictionariesAndMaps")]
        public void DictionariesAndMaps2()
        {
            List<String> testInput = new List<String> {
                "3",
                "sam 99912222",
                "tom 11122222",
                "harry 12299933",
                "edward" };

            List<String> expectedOutput = new List<String> {
                         "Not found" };

            List<String> actualOutput = ThirtyDayClasses.Day08DictionariesAndMaps.Dictionary(testInput);

            Assert.AreEqual(expectedOutput[0], actualOutput[0], "edward Is Wrong");
            
        }

        [TestMethod]
        [TestCategory("Day08DictionariesAndMaps")]
        public void DictionariesAndMaps3()
        {
            List<String> testInput = new List<String> {
                "4",
                "sam 99912222",
                "tom 11122222",
                "harry 12299933",
                "ed 12345678",
                "edward" };

            List<String> expectedOutput = new List<String> {
                         "Not found" };

            List<String> actualOutput = ThirtyDayClasses.Day08DictionariesAndMaps.Dictionary(testInput);
            
            Assert.AreEqual(expectedOutput[0], actualOutput[0], "Edward is wrong");

        }

        [TestMethod]
        [TestCategory("Day08DictionariesAndMaps")]
        public void DictionariesAndMaps4()
        {
            List<String> testInput = new List<String> {
                "4",
                "sam 99912222",
                "tom 11122222",
                "harry 12299933",
                "ed 12345678",
                "edward",
                "sam",
                "Sam",
                "tom",
                "harry",
                "susie",
                "jack",
                "jill",
                "Renmin"};

            List<String> expectedOutput = new List<String> {
                "Not found",
                "sam=99912222",
                "Not found",
                "tom=11122222",
                "harry=12299933",
                "Not found",
                "Not found",
                "Not found",
                "Not found"};

            List<String> actualOutput = ThirtyDayClasses.Day08DictionariesAndMaps.Dictionary(testInput);

            for (int result = 0; result < 9; result++)
            {
                Assert.AreEqual(expectedOutput[result], actualOutput[result], string.Format("{0} Is Wrong",testInput[result+5]));
            }

        }

        #endregion

        #region 09 Recursion
        [TestMethod]
        [TestCategory("Day09Recursion")]
        public void RecusionTest1()
        {
            int inputValue = 3;

            int expectedResult = 6;

            int actualResult = ThirtyDayClasses.Day09Recursion.factorial(inputValue);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [TestCategory("Day09Recursion")]
        public void RecusionTest2()
        {
            int inputValue = 10;

            int expectedResult = 3628800;

            int actualResult = ThirtyDayClasses.Day09Recursion.factorial(inputValue);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [TestCategory("Day09Recursion")]
        public void RecusionTest3()
        {
            int inputValue = 50;

            // return value larger than int... so, it's 0
            int expectedResult = 0;

            int actualResult = ThirtyDayClasses.Day09Recursion.factorial(inputValue);

            Assert.AreEqual(expectedResult, actualResult);
        }

        #endregion

        #region 10 BinaryNumbers

        [TestMethod]
        [TestCategory("Day10BinaryNumbers")]
        public void BinaryNumberTest1()
        {
            string testInput = "5";

            string expectedOutput = "1";

            string actualOutput = ThirtyDayClasses.Day10BinaryNumbers.ConsecutiveOnes(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);


        }

        [TestMethod]
        [TestCategory("Day10BinaryNumbers")]
        public void BinaryNumberTest2()
        {
            string testInput = "13";

            string expectedOutput = "2";

            string actualOutput = ThirtyDayClasses.Day10BinaryNumbers.ConsecutiveOnes(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);


        }
        [TestMethod]
        [TestCategory("Day10BinaryNumbers")]
        public void BinaryNumberTest3()
        {
            string testInput = "255";

            string expectedOutput = "8";

            string actualOutput = ThirtyDayClasses.Day10BinaryNumbers.ConsecutiveOnes(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);


        }

        [TestMethod]
        [TestCategory("Day10BinaryNumbers")]
        public void BinaryNumberTest4()
        {
            string testInput = "0";

            string expectedOutput = "0";

            string actualOutput = ThirtyDayClasses.Day10BinaryNumbers.ConsecutiveOnes(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);


        }
        #endregion

        #region 11 2D-Arrays

        [TestMethod]
        [TestCategory("Day112DArrays")]
        public void TwoDimArrayTest1()
        {
            List<string> testInput = new List<string>
            {
                "1 1 1 0 0 0",
                "0 1 0 0 0 0",
                "1 1 1 0 0 0",
                "0 0 2 4 4 0",
                "0 0 0 2 0 0",
                "0 0 1 2 4 0"
            };

            string expectedOutput = "19";

            string actualOutput = ThirtyDayClasses.Day112DArrays.LargestHourGlass(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);

        }

        [TestMethod]
        [TestCategory("Day112DArrays")]
        public void TwoDimArrayTest2()
        {
            List<string> testInput = new List<string>
            {
                "1 1 1 0 0 0",
                "0 1 0 0 0 0",
                "1 1 1 0 0 0",
                "0 0 2 4 4 0",
                "0 0 9 2 0 0",
                "0 0 1 2 4 0"
            };

            string expectedOutput = "19";

            string actualOutput = ThirtyDayClasses.Day112DArrays.LargestHourGlass(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);

        }

        #endregion

    }
}
