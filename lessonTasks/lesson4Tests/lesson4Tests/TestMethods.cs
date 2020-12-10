using Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson4Tests
{
    class TestMethods
    {
        //Простой метод сравения двух интов, используется единожды 
        static void AssertEquals(int expected, int actual)
        {
            if (expected == actual)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"TEST FAILED \n VALUE ARE EQUAL: {actual} \n INSTEAD: {expected}");
            }
            Console.ResetColor();
        }

        //Тест для сравнения массивов поэлементно
        static void AssertEquals(int[] expected, int[] actual)
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] == actual[i])
                {
                    if (i == expected.Length - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("SUCCESS");
                    }
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"TEST FAILED \n VALUE ARE EQUAL: {actual[i]} \n INSTEAD: {expected[i]}\n on index {i} in array");
                    break;
                }
            }
            Console.ResetColor();
        }

        //Тест для сравнения двух коллекция типа Dictionary
        static void AssertEquals(Dictionary<int, double> expected, Dictionary<int, double> actual)
        {
            bool flag = true;
            foreach (var key in expected.Keys.ToList())
            {
                foreach (var _key in actual.Keys.ToList())
                {
                    if (expected[key] == actual[_key])
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"TEST FAILED. FREQUENCES IN DICTIONARIES NOT EQUAL");
            }
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            #region TASK_2 , _1 TESTS
            int[] arr = new int[5] { 6, 2, 9, -3, 6 };
            int actualValue = StaticClass.DividedByNumber(arr);
            int expectedValue = 2;

            AssertEquals(expectedValue, actualValue);

            int[] actual = StaticClass.ArrayFromTextFile();
            int[] expected = new int[15] { 16, 123, 23, 123, 12334, 34, 5634, 123, 0, 123, 0, 343, 0, 43, 42 };

            AssertEquals(actual, expected);
            #endregion

            #region TASK_3 TESTS
            //Class constructor test
            int[] expectedArray = new int[5] { 2, 5, 8, 11, 14 };
            int[] actualArray = new OneDimArray(5, 2, 3).GetArr;

            AssertEquals(expectedArray, actualArray);

            expectedArray = new int[10] { 8, 6, 4, 2, 0, -2, -4, -6, -8, -10 };
            actualArray = new OneDimArray(10, 8, -2).GetArr;

            AssertEquals(expectedArray, actualArray);
            //
            //
            //
            //INVERSE METHOD TESTS
            expectedArray = new int[5] { -2, -5, -8, -11, -14 };
            actualArray = new OneDimArray(5, 2, 3).Inverse();

            AssertEquals(expectedArray, actualArray);

            expectedArray = new int[10] { -8, -6, -4, -2, 0, 2, 4, 6, 8, 10 };
            actualArray = new OneDimArray(10, 8, -2).Inverse();

            AssertEquals(expectedArray, actualArray);
            //
            //
            //
            //MULTI METHOD TESTS
            expectedArray = new int[10] { 24, 18, 12, 6, 0, -6, -12, -18, -24, -30 };
            actualArray = new OneDimArray(10, 8, -2).Multi(3);

            AssertEquals(expectedArray, actualArray);
            //
            //
            //
            //SUMMARY PROPERTY TESTS
            expectedValue = 40;
            actualValue = new OneDimArray(5, 2, 3).Summary;

            AssertEquals(expectedValue, actualValue);

            expectedValue = -10;
            actualValue = new OneDimArray(10, 8, -2).Summary;

            AssertEquals(expectedValue, actualValue);
            //
            //
            //CLASS DICTIONARY TEST
            //GET_ELEM_FREQ TEST
            Dictionary<int, int> testColl = new Dictionary<int, int>(4);
            testColl.Add(4, 1);
            testColl.Add(1, 1);
            testColl.Add(5, 1);
            testColl.Add(0, 1);
            Dictionary<int, double> expectedDict = new Dictionary<int, double>(4);
            expectedDict.Add(4, 0.25);
            expectedDict.Add(1, 0.25);
            expectedDict.Add(5, 0.25);
            expectedDict.Add(0, 0.25);

            Dictionary<int, double> actualDict = _Dictionary.GetElemFreq(testColl);

            AssertEquals(expectedDict, actualDict);
            #endregion

            #region TASK_4 Demonstration
            //Account.AccountCheck(Account.GetAccountDataBase());

            #endregion

            #region TASK_5_a demonstration
            TwoDimArray dimArray = new TwoDimArray(2, 2);
            int[,] testArr = dimArray.GetArr;
            for (int i = 0; i < dimArray.GetStringCount; i++)
            {
                for (int j = 0; j < dimArray.GetColCount; j++)
                {
                    Console.Write($"{testArr[i, j]} ");
                }
                Console.Write("\n");
            }

            //ALL_SUMM METHOD
            Console.WriteLine($"{dimArray.AllSumm()}");
            //MORE_THAN METHOD
            Console.WriteLine($"{dimArray.MoreThanSum(58000)}");
            //INDEX_OF METHOD
            foreach (int index in dimArray.IndexOf(dimArray.GetArrMax))
            {
                Console.Write($"[{index}], ");
            }
            #endregion
        }
    }
}
