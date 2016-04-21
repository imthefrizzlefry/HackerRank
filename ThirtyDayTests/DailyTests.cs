using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirtyDayClasses;
using System.Collections.Generic;
using System.IO;

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



        #region 07 Arrays

        [TestMethod]
        [TestCategory("Day07Arrays")]
        public void ArraysTest1()
        {
            List<string> testInput = new List<string>
            {
                "4",
                "1 4 3 2"
            };

            string expectedOutput = "2 3 4 1";

            string actualOutput = ThirtyDayClasses.Day07Arrays.ReverseArray(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Day07Arrays")]
        public void ArraysTest2()
        {
            List<string> testInput = new List<string>
            {
                "1",
                "4"
            };

            string expectedOutput = "4";

            string actualOutput = ThirtyDayClasses.Day07Arrays.ReverseArray(testInput);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Day07Arrays")]
        public void ArraysTest3()
        {
            List<string> testInput = new List<string>
            {
                "5",
                "4 8 9 3 0"
            };

            string expectedOutput = "0 3 9 8 4";

            string actualOutput = ThirtyDayClasses.Day07Arrays.ReverseArray(testInput);

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

        #region 12 Inheritance

        [TestMethod]
        [TestCategory("Day12Inheritance")]
        public void InheritanceTest1()
        {
            string firstName = "Heraldo";
            string lastName = "Memelli";
            int id = 8135627;
            int[] scores = new int[] { 100, 80 };


            ThirtyDayClasses.Student studentUnderTest = new Student(firstName, lastName, id, scores);

            List<string> expectedOutput = new List<string>
            {
                "Name: Memelli, Heraldo",
                "ID: 8135627",
                "Grade: O"
            };

            List<string> actualOutput = studentUnderTest.getStudentData();

            Assert.AreEqual(expectedOutput[0], actualOutput[0], "Name Is Wrong");
            Assert.AreEqual(expectedOutput[1], actualOutput[1], "ID Is Wrong");
            Assert.AreEqual(expectedOutput[2], actualOutput[2], "Grade Is Wrong");

        }

        [TestMethod]
        [TestCategory("Day12Inheritance")]
        public void InheritanceTest2()
        {
            string firstName = "Heraldo";
            string lastName = "Memelli";
            int id = 8135627;
            int[] scores = new int[] { 90, 80 };


            ThirtyDayClasses.Student studentUnderTest = new Student(firstName, lastName, id, scores);

            char expectedOutput = 'E';

            char actualOutput = studentUnderTest.calculate();

            Assert.AreEqual(expectedOutput, actualOutput, "Grade Is Wrong");

        }

        [TestMethod]
        [TestCategory("Day12Inheritance")]
        public void InheritanceTest3()
        {
            string firstName = "Heraldo";
            string lastName = "Memelli";
            int id = 8135627;
            int[] scores = new int[] { 80, 70 };


            ThirtyDayClasses.Student studentUnderTest = new Student(firstName, lastName, id, scores);

            char expectedOutput = 'A';

            char actualOutput = studentUnderTest.calculate();

            Assert.AreEqual(expectedOutput, actualOutput, "Grade Is Wrong");

        }

        [TestMethod]
        [TestCategory("Day12Inheritance")]
        public void InheritanceTest4()
        {
            string firstName = "Heraldo";
            string lastName = "Memelli";
            int id = 8135627;
            int[] scores = new int[] { 55, 70 };


            ThirtyDayClasses.Student studentUnderTest = new Student(firstName, lastName, id, scores);

            char expectedOutput = 'P';

            char actualOutput = studentUnderTest.calculate();

            Assert.AreEqual(expectedOutput, actualOutput, "Grade Is Wrong");

        }


        [TestMethod]
        [TestCategory("Day12Inheritance")]
        public void InheritanceTest5()
        {
            string firstName = "Heraldo";
            string lastName = "Memelli";
            int id = 8135627;
            int[] scores = new int[] { 40 };


            ThirtyDayClasses.Student studentUnderTest = new Student(firstName, lastName, id, scores);

            char expectedOutput = 'D';

            char actualOutput = studentUnderTest.calculate();

            Assert.AreEqual(expectedOutput, actualOutput, "Grade Is Wrong");

        }

        [TestMethod]
        [TestCategory("Day12Inheritance")]
        public void InheritanceTest6()
        {
            string firstName = "Heraldo";
            string lastName = "Memelli";
            int id = 8135627;
            int[] scores = new int[] { 10, 20, 30, 40 };


            ThirtyDayClasses.Student studentUnderTest = new Student(firstName, lastName, id, scores);

            char expectedOutput = 'T';

            char actualOutput = studentUnderTest.calculate();

            Assert.AreEqual(expectedOutput, actualOutput, "Grade Is Wrong");

        }
        #endregion

        #region 13 AbstractClasses

        [TestMethod]
        [TestCategory("Day13AbstractClassesTests")]
        public void AbstractClassTest1()
        {

            String title = "The Alchemist";
            String author = "Paulo Coelho";
            int price = 248;

            string expectedTitle = "Title: " + title;
            string expectedAuthor = "Author: " + author;
            string expectedPrice = "Price: " + price.ToString();

            Book new_novel = new MyBook(title, author, price);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                new_novel.display();

                string[] actualResult = sw.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                Assert.AreEqual(expectedTitle, actualResult[0]);
                Assert.AreEqual(expectedAuthor, actualResult[1]);
                Assert.AreEqual(expectedPrice, actualResult[2]);

            }
            
        }

        #endregion

        #region 14 Scope

        [TestMethod]
        [TestCategory("Day14Scope")]
        public void ScopeTest1()
        {
            int[] a = new int[] { 1, 2, 5 };
            int expectedOutput = 4;

            Difference d = new Difference(a);

            d.computeDifference();

            int actualOutput = d.maximumDifference;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Day14Scope")]
        public void ScopeTest2()
        {
            int[] a = new int[] { 8, 19, 3, 2, 7 };
            int expectedOutput = 17;

            Difference d = new Difference(a);

            d.computeDifference();

            int actualOutput = d.maximumDifference;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        [TestCategory("Day14Scope")]
        public void ScopeTest3()
        {
            int[] a = new int[] { 8, 8, 8, 8, 8 };
            int expectedOutput = 0;

            Difference d = new Difference(a);

            d.computeDifference();

            int actualOutput = d.maximumDifference;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        #endregion

        #region 15 LinkedLists
        
        [TestMethod]
        [TestCategory("Day15LinkedListsTests")]
        public void LinkedListsTest1()
        {
            Node head = null;
            int[] testInput = new int[] { 2, 3, 4, 1 };

            string expectedResult = "2 3 4 1 ";

            foreach(int data in testInput)
            {
                head = Day15LinkedList.insert(head, data);
            }

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Day15LinkedList.display(head);

                string actualResult = sw.ToString();

                Assert.AreEqual(expectedResult, actualResult);

            }
            
        }

        #endregion

        #region
        
        [TestMethod]
        [TestCategory("Day16ExceptionsStringToIntegerTests")]
        public void ExceptionsStringToIntegerTest1()
        {
            using (var sw = new StringWriter())
            {
                string testInput = "3";

                string expectedResult = "3";

                using (var sr = new StringReader(testInput))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    Day16ExceptionsStringToInteger.CatchParsingException();

                    // Assert
                    string actualResult = sw.ToString();

                    Assert.AreEqual(expectedResult, actualResult);
                }
            }
        }

        [TestMethod]
        [TestCategory("Day16ExceptionsStringToIntegerTests")]
        public void ExceptionsStringToIntegerTest2()
        {
            using (var sw = new StringWriter())
            {
                string testInput = "za";

                string expectedResult = "Bad String";

                using (var sr = new StringReader(testInput))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    Day16ExceptionsStringToInteger.CatchParsingException();

                    // Assert
                    string actualResult = sw.ToString();

                    Assert.AreEqual(expectedResult, actualResult);
                }
            }
        }

        [TestMethod]
        [TestCategory("Day16ExceptionsStringToIntegerTests")]
        public void ExceptionsStringToIntegerTest3()
        {
            using (var sw = new StringWriter())
            {
                string testInput = "3134";

                string expectedResult = "3134";

                using (var sr = new StringReader(testInput))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    Day16ExceptionsStringToInteger.CatchParsingException();

                    // Assert
                    string actualResult = sw.ToString();

                    Assert.AreEqual(expectedResult, actualResult);
                }
            }
        }

        [TestMethod]
        [TestCategory("Day16ExceptionsStringToIntegerTests")]
        public void ExceptionsStringToIntegerTest4()
        {
            using (var sw = new StringWriter())
            {
                string testInput = "abc";

                string expectedResult = "Bad String";

                using (var sr = new StringReader(testInput))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    Day16ExceptionsStringToInteger.CatchParsingException();

                    // Assert
                    string actualResult = sw.ToString();

                    Assert.AreEqual(expectedResult, actualResult);
                }
            }
        }


        #endregion
    }
}
