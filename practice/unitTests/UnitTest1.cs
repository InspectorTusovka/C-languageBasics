using Lesson_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 

namespace unitTests
{
    [TestClass]
    public class UnitTest1
    {
        double expected;
        double actual;
        double tolerance;

        [TestMethod]
        public void TestMethod1()
        {
            Lesson_2.Lesson2Tasks task_1 = new Lesson2Tasks();
            expected = -1;
            actual = Lesson2Tasks.threeNumMin(-1, -1, -1);
            tolerance = 0.001;
            Assert.AreEqual(expected, actual,tolerance);

            expected = -1;
            actual = Lesson2Tasks.threeNumMin(0, 12, -1);
            tolerance = 0.001;
            Assert.AreEqual(expected, actual, tolerance);

            expected = -1;
            actual = Lesson2Tasks.threeNumMin(1, -1, 16);
            tolerance = 0.001;
            Assert.AreEqual(expected, actual, tolerance);

            expected = -1;
            actual = Lesson2Tasks.threeNumMin(-1, 16, 15);
            tolerance = 0.001;
            Assert.AreEqual(expected, actual, tolerance);

            expected = -1;
            actual = Lesson2Tasks.threeNumMin(-1, 15, 16);
            tolerance = 0.001;
            Assert.AreEqual(expected, actual, tolerance);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Lesson_2.Lesson2Tasks task_2 = new Lesson2Tasks();
            actual = Lesson2Tasks.numeralCountInNumber(245.23);
            expected = 5;
            tolerance = 0.001;
            Assert.AreEqual(expected, actual, tolerance);

            actual = Lesson2Tasks.numeralCountInNumber(245);
            expected = 3;
            tolerance = 0.001;
            Assert.AreEqual(expected, actual, tolerance);

            actual = Lesson2Tasks.numeralCountInNumber(0.42);
            expected = 3;
            tolerance = 0.001;
            Assert.AreEqual(expected, actual, tolerance);
        }

        //[TestMethod]
       /* public void TestMethod3() //Каким образом можно запустить юнит тест, если метод класса не запрашивает параметры?
        {
            Lesson_2.Lesson2Tasks task_3 = new Lesson2Tasks();
            actual = Lesson2Tasks.oddPositiveNumCounter();
            expected = 4;
            tolerance = 0.001;
            Assert.AreEqual(expected,actual,tolerance);
        }*/

        [TestMethod]
        public void TestMethod3()
        {
            Lesson_2.Lesson2Tasks task_6 = new Lesson2Tasks();
            actual = Lesson2Tasks.goodNumCounter(1,1000000);
            expected = 95428;
            tolerance = 0.001;
            Assert.AreEqual(expected,actual,tolerance);


            actual = Lesson2Tasks.goodNumCounter(1, 11);
            expected = 10;
            tolerance = 0.001;
            Assert.AreEqual(expected, actual, tolerance);

            actual = Lesson2Tasks.goodNumCounter(1, 1000);
            expected = 213;
            tolerance = 0.001;
            Assert.AreEqual(expected, actual, tolerance);
        }

    }
}
