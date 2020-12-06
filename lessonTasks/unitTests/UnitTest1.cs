using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lessonTasks;

namespace unitTests
{
    [TestClass]
    public class UnitTest1
    {
        lesson3Tasks.Complex expected = new lesson3Tasks.Complex();
        lesson3Tasks.Complex actual = new lesson3Tasks.Complex();
        lesson3Tasks.Complex tolerance = new lesson3Tasks.Complex(0.001, 0.001);
        lesson3Tasks.Complex testOperand_1 = new lesson3Tasks.Complex();
        lesson3Tasks.Complex testOperand_2 = new lesson3Tasks.Complex();

        [TestMethod]
        public void TestMethod1()
        {
            expected.imChange = 4;
            expected.reChange = 3;
            testOperand_1.reChange = 2;
            testOperand_1.imChange = 1;
            testOperand_2.reChange = 2;
            testOperand_2.imChange = 2;

            actual.Plus(testOperand_1,testOperand_2);
            Assert.AreEqual<lesson3Tasks.Complex>(expected, actual);
        }
    }
}
