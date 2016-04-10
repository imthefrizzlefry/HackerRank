using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRankChallengeCode;
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

            string actualOutput = HackerRankChallengeCode.Day00HelloWorld.Hello(testString);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Day00HelloWorld")]
        public void HelloWorldTest2()
        {
            string testString = " HackerRank is the best!";
            string expectedOutput = "Hello, World." + testString;

            string actualOutput = HackerRankChallengeCode.Day00HelloWorld.Hello(testString);

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

            List<String> actualOutput = HackerRankChallengeCode.Day01DataTypes.DataTypes(testInput);

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

            String actualOutput = HackerRankChallengeCode.Day02Operators.MealTotal(testInput);

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

            String actualOutput = HackerRankChallengeCode.Day02Operators.MealTotal(testInput);

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

            List<String> actualOutput = HackerRankChallengeCode.Day08DictionariesAndMaps.Dictionary(testInput);

            Assert.AreEqual(expectedOutput[0], actualOutput[0], "Sam Is Wrong");
            Assert.AreEqual(expectedOutput[1], actualOutput[1], "Edward is wrong");
            Assert.AreEqual(expectedOutput[2], actualOutput[2], "Harry is wrong");

        }
        #endregion

    }
}
