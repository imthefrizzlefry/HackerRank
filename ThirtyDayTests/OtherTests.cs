﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRankChallengeCode;

namespace ThirtyDayTests
{
    /// <summary>
    /// Summary description for OtherTests
    /// </summary>
    [TestClass]
    public class OtherTests
    {
        public OtherTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region Serlock Squares tests
        [TestMethod]
        [TestCategory("SherlockSquares")]
        public void SherlockTest1()
        {
            List<String> testInput = new List<String> {
                "1",
                "3 9" };

            List<String> expectedOutput = new List<String> {
                "2" };

            List<String> actualOutput = HackerRankChallengeCode.SherlockSquares.CountSquares(testInput);

            Assert.AreEqual(expectedOutput[0], actualOutput[0], "The IncorrectCount is wrong for {0}", 0);
        }

        [TestMethod]
        [TestCategory("SherlockSquares")]
        public void SherlockTest2()
        {
            #region Input Data of 100 items
            List<String> testInput = new List<String> {
                "100",
                "11 734",
                "228 919",
                "71 188",
                "270 303",
                "312 701",
                "251 325",
                "418 954",
                "407 597",
                "4 4",
                "248 583",
                "318 936",
                "176 769",
                "323 838",
                "383 981",
                "152 560",
                "94 217",
                "232 442",
                "180 447",
                "384 819",
                "175 842",
                "81 451",
                "381 771",
                "260 669",
                "95 558",
                "111 926",
                "212 676",
                "368 424",
                "153 373",
                "127 305",
                "402 737",
                "134 236",
                "130 696",
                "8 963",
                "150 378",
                "214 813",
                "242 944",
                "397 743",
                "437 951",
                "295 469",
                "211 865",
                "284 683",
                "125 928",
                "382 484",
                "288 559",
                "273 585",
                "375 376",
                "398 873",
                "362 950",
                "301 539",
                "459 820",
                "243 942",
                "135 432",
                "352 681",
                "261 597",
                "220 440",
                "311 320",
                "274 287",
                "154 806",
                "444 679",
                "360 962",
                "53 571",
                "191 426",
                "269 807",
                "83 141",
                "464 503",
                "61 565",
                "342 857",
                "347 852",
                "497 589",
                "237 803",
                "397 789",
                "356 398",
                "101 822",
                "122 654",
                "294 731",
                "111 236",
                "257 646",
                "438 478",
                "230 457",
                "118 386",
                "485 516",
                "260 435",
                "423 569",
                "144 930",
                "108 989",
                "351 815",
                "493 605",
                "499 720",
                "21 121",
                "30 515",
                "107 997",
                "398 437",
                "105 997",
                "40 363",
                "170 807",
                "177 296",
                "49 211",
                "91 582",
                "44 940",
                "1 1000" };
            #endregion

            #region Expected Output
            List<String> expectedOutput = new List<String> {
                "24",
                "15",
                "5",
                "1",
                "9",
                "3",
                "10",
                "4",
                "1",
                "9",
                "13",
                "14",
                "11",
                "12",
                "11",
                "5",
                "6",
                "8",
                "9",
                "16",
                "13",
                "8",
                "9",
                "14",
                "20",
                "12",
                "1",
                "7",
                "6",
                "7",
                "4",
                "15",
                "29",
                "7",
                "14",
                "15",
                "8",
                "10",
                "4",
                "15",
                "10",
                "19",
                "3",
                "7",
                "8",
                "0",
                "10",
                "11",
                "6",
                "7",
                "15",
                "9",
                "8",
                "8",
                "6",
                "0",
                "0",
                "16",
                "5",
                "13",
                "16",
                "7",
                "12",
                "2",
                "1",
                "16",
                "11",
                "11",
                "2",
                "13",
                "9",
                "1",
                "18",
                "14",
                "10",
                "5",
                "9",
                "1",
                "6",
                "9",
                "0",
                "4",
                "3",
                "19",
                "21",
                "10",
                "2",
                "4",
                "7",
                "17",
                "21",
                "1",
                "21",
                "13",
                "15",
                "4",
                "8",
                "15",
                "24",
                "31" };
            #endregion

            List<String> actualOutput = HackerRankChallengeCode.SherlockSquares.CountSquares(testInput);

            Assert.AreEqual(expectedOutput[0], actualOutput[0], "The IncorrectCount is wrong for {0}", 0);
        }
        #endregion
    }
}
