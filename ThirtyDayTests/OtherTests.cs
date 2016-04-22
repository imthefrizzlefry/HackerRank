using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OtherChallenges;
using System.IO;
using System.Linq;

namespace ThirtyDayTests
{
    /// <summary>
    /// Summary description for OtherTests
    /// </summary>
    [TestClass]
    public class OtherTests
    {
        
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

            List<String> actualOutput = OtherChallenges.SherlockSquares.CountSquares(testInput);

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

            List<String> actualOutput = OtherChallenges.SherlockSquares.CountSquares(testInput);

            Assert.AreEqual(expectedOutput[0], actualOutput[0], "The IncorrectCount is wrong for {0}", 0);
        }
        #endregion

        #region Service Lane tests

        [TestMethod]
        [TestCategory("ServiceLane")]
        public void ServiceLaneTest1()
        {
            List<String> testInput = new List<String> {
                "8 5",
                "2 3 1 2 3 2 3 3",
                "0 3",
                "4 6",
                "6 7",
                "3 5",
                "0 7" };

            List<String> expectedOutput = new List<String> {
                "1",
                "2",
                "3",
                "2",
                "1" };

            List<String> actualOutput = OtherChallenges.ServiceLane.UsableVehicle(testInput);
            int outputCounter = 0;

            foreach (var expectedValue in expectedOutput)
            {                
                Assert.AreEqual(expectedValue, actualOutput[outputCounter], string.Format("Value {0} was incorrect.", outputCounter+1));
                outputCounter++;
            }

        }

        [TestMethod]
        [TestCategory("ServiceLane")]
        public void ServiceLaneTest2()
        {
            List<String> testInput = new List<String> {
                "5 5",
                "1 2 2 2 1",
                "2 3",
                "1 4",
                "2 4",
                "2 4",
                "2 3" };

            List<String> expectedOutput = new List<String> {
                "2",
                "1",
                "1",
                "1",
                "2" };

            List<String> actualOutput = OtherChallenges.ServiceLane.UsableVehicle(testInput);
            int outputCounter = 0;

            foreach (var expectedValue in expectedOutput)
            {
                Assert.AreEqual(expectedValue, actualOutput[outputCounter], string.Format("Value {0} was incorrect.", outputCounter + 1));
                outputCounter++;
            }

        }

        #endregion

        #region Cut Sticks Tests
        [TestMethod]
        [TestCategory("CutTheSticks")]
        public void CutSticksTest1()
        {
            List<String> testInput = new List<String> {
                "6",
                "5 4 4 2 2 8" };

            List<String> expectedOutput = new List<String> {
                "6",
                "4",
                "2",
                "1" };

            List<String> actualOutput = OtherChallenges.CutTheSticks.NumberOfCuts(testInput);

            int outputCounter = 0;

            foreach (var expectedValue in expectedOutput)
            {
                Assert.AreEqual(expectedValue, actualOutput[outputCounter], string.Format("Cut {0} was incorrect. it should be {1}", outputCounter, expectedValue ));
                outputCounter++;
            }
        }

        [TestMethod]
        [TestCategory("CutTheSticks")]
        public void CutSticksTest2()
        {
            List<String> testInput = new List<String> {
                "8",
                "1 2 3 4 3 3 2 1" };

            List<String> expectedOutput = new List<String> {
                "8",
                "6",
                "4",
                "1" };

            List<String> actualOutput = OtherChallenges.CutTheSticks.NumberOfCuts(testInput);

            int outputCounter = 0;

            foreach (var expectedValue in expectedOutput)
            {
                Assert.AreEqual(expectedValue, actualOutput[outputCounter], string.Format("Cut {0} was incorrect. it should be {1}", outputCounter, expectedValue));
                outputCounter++;
            }
        }

        #endregion

        #region Caesar Cipher Tests

        [TestMethod]
        [TestCategory("CaesarCipher")]
        public void CaesarCipherTest1()
        {
            List<string> testInput = new List<string>
            {
                "11",
                "middle-Outz",
                "2"
            };

            string expectedOutput = "okffng-Qwvb";

            string actualOutput = OtherChallenges.CaesarCipher.Encode(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("CaesarCipher")]
        public void CaesarCipherTest2()
        {
            List<string> testInput = new List<string>
            {
                "10",
                "www.abc.xy",
                "87"
            };

            string expectedOutput = "fff.jkl.gh";

            string actualOutput = OtherChallenges.CaesarCipher.Encode(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);
        }



        #endregion

        #region Library Fine Tests

        [TestMethod]
        [TestCategory("LibraryFine")]
        public void LibraryFineTest1()
        {
            List<string> testInput = new List<string>
            {
                "9 6 2015",
                "6 6 2015"
            };

            string expectedOutput = "45";

            string actualOutput = OtherChallenges.LibraryFine.CalculateLateFee(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);

        }

        [TestMethod]
        [TestCategory("LibraryFine")]
        public void LibraryFineTest2()
        {
            List<string> testInput = new List<string>
            {
                "1 7 2015",
                "31 6 2015"
            };

            string expectedOutput = "500";

            string actualOutput = OtherChallenges.LibraryFine.CalculateLateFee(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);

        }

        [TestMethod]
        [TestCategory("LibraryFine")]
        public void LibraryFineTest3()
        {
            List<string> testInput = new List<string>
            {
                "30 12 2015",
                "1 1 2015"
            };

            string expectedOutput = "5500";

            string actualOutput = OtherChallenges.LibraryFine.CalculateLateFee(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);

        }

        [TestMethod]
        [TestCategory("LibraryFine")]
        public void LibraryFineTest4()
        {
            List<string> testInput = new List<string>
            {
                "1 1 2016",
                "31 12 2015"
            };

            string expectedOutput = "10000";

            string actualOutput = OtherChallenges.LibraryFine.CalculateLateFee(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);

        }

        #endregion

        #region Fibonacci Modified Tests

        [TestMethod]
        [TestCategory("FibonacciModified")]
        public void FibonacciModifiedTest1()
        {
            string testInput = "0 1 5";
            string expectedOutput = "5";
            string actualOutput = OtherChallenges.FibModified.Calculate(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("FibonacciModified")]
        public void FibonacciModifiedTest2()
        {
            string testInput = "0 1 10";
            string expectedOutput = "84266613096281243382112";
            string actualOutput = OtherChallenges.FibModified.Calculate(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        #endregion

        #region Adding Numbers As Strings Tests

        [TestMethod]
        [TestCategory("AddingNumbersAsStrings")]
        public void StringAdderTest1()
        {
            string testInputA = "1";
            string testInputB = "1";

            string expectedOutput = "2";

            string actualOutput = OtherChallenges.AddingNumbersAsStrings.StringAdder(testInputA, testInputB);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("AddingNumbersAsStrings")]
        public void StringAdderTest2()
        {
            string testInputA = "9";
            string testInputB = "1";

            string expectedOutput = "10";

            string actualOutput = OtherChallenges.AddingNumbersAsStrings.StringAdder(testInputA, testInputB);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("AddingNumbersAsStrings")]
        public void StringAdderTest3()
        {
            string testInputA = "89999";
            string testInputB = "1";

            string expectedOutput = "90000";

            string actualOutput = OtherChallenges.AddingNumbersAsStrings.StringAdder(testInputA, testInputB);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("AddingNumbersAsStrings")]
        public void StringAdderTest4()
        {
            string testInputA = "109";
            string testInputB = "1";

            string expectedOutput = "110";

            string actualOutput = OtherChallenges.AddingNumbersAsStrings.StringAdder(testInputA, testInputB);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("AddingNumbersAsStrings")]
        public void StringAdderTest5()
        {
            string testInputA =     "11547890578905329880521782596491481461468164334854313481335141354813548134831483148134813548153481485853814809";
            string testInputB =                      "503000000000000000040000000000000000020000000000000000435288135000000000000000000000000000001";
            string expectedOutput = "11547890578905330383521782596491481501468164334854313501335141354813548570119618148134813548153481485853814810";

            string actualOutput = OtherChallenges.AddingNumbersAsStrings.StringAdder(testInputA, testInputB);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("AddingNumbersAsStrings")]
        public void StringAdderTest6()
        {
            string testInputA = "52";
            string testInputB = "309427";
            string expectedOutput = "309479";

            string actualOutput = OtherChallenges.AddingNumbersAsStrings.StringAdder(testInputA, testInputB);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        #endregion

        #region Bot Saves Princess Tests

        private static void RunBotSavesPrincessTestHelper(string testInput, string[] expectedResult)
        {
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(testInput))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    BotSavesPrincess.SaveThePrincess();

                    string[] actualResult = sw.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    Assert.AreEqual(expectedResult.Length, actualResult.Length);

                    for (int x = 0; x < expectedResult.Length; x++)
                    {
                        Assert.AreEqual(expectedResult[x], actualResult[x]);
                    }
                }
            }
        }


        [TestMethod]
        [TestCategory("BotSavesPrincessTests")]
        public void BotSavesPrincessTest1()
        {
            string testInput = "3\n"
                + "---\n"
                + "-m-\n"
                + "p--";

            string[] expectedResult = new string[]
            {
                "DOWN",
                "LEFT"
            };
            RunBotSavesPrincessTestHelper(testInput, expectedResult);
        }


        [TestMethod]
        [TestCategory("BotSavesPrincessTests")]
        public void BotSavesPrincessTest2()
        {
            string testInput = "12\n"
                + "------------\n"
                + "------------\n"
                + "---m--------\n"
                + "------------\n"
                + "------------\n"
                + "------------\n"
                + "------------\n"
                + "------------\n"
                + "------------\n"
                + "------------\n"
                + "---------p--\n"
                + "------------";

            string[] expectedResult = new string[]
            {
                "DOWN",
                "DOWN",
                "DOWN",
                "DOWN",
                "DOWN",
                "DOWN",
                "DOWN",
                "DOWN",
                "RIGHT",
                "RIGHT",
                "RIGHT",
                "RIGHT",
                "RIGHT",
                "RIGHT"
            };
            RunBotSavesPrincessTestHelper(testInput, expectedResult);
        }

        #endregion
    }
}
