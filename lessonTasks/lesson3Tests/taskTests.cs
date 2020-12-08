using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lessonTasks;

namespace lesson3Tests 
{
    class taskTests //Доп проект и класс для тестирования методов классов из lesson3Tasks
    {



        // Тест типа AssertEqual для структуры Complex
        static void StructElemAreEqual(lesson3Tasks.Complex expected, lesson3Tasks.Complex actual)
        {
            if(expected.re == actual.re && expected.im == actual.im)
            {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"TEST FAILED \n VALUES ARE EQUAL: {actual.re} AND {actual.im} \n INSTEAD: {expected.re} AND {expected.im} ");
            }
            Console.ResetColor();   
        }

        // Тест типа AssertEqual для класса Complex
        static void ClassElemAreEqual(lesson3Tasks.ComplexAsClass expected, lesson3Tasks.ComplexAsClass actual)
        {
            if (expected._re == actual._re && expected._im == actual._im)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"TEST FAILED \n VALUES ARE EQUAL: {actual._re} AND {actual._im} " +
                    $"\n INSTEAD: {expected._re} AND {expected._im} ");
            }
            Console.ResetColor();
        }

        // Тест типа AssertEqual для класса Fraction
        static void FractionAreEqual(lesson3Tasks.Fraction expected, lesson3Tasks.Fraction actual)
        {
            if (expected.nomiChange == actual.nomiChange && expected.denomiChange == actual.denomiChange && expected._IntPart == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESS");
            }
            else if (expected._IntPart != 0 && expected._IntPart == actual._IntPart || 
                (expected.nomiChange == actual.nomiChange && expected.denomiChange == actual.denomiChange))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESS");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"TEST FAILED \n VALUES ARE EQUAL: {actual.ToString()} " +
                    $"\n INSTEAD: {expected.ToString()} ");
            }
            Console.ResetColor();
        }
        static void Main(string[] args)
        {

            try {  //Обработка исключения DivideByZero
            #region TASK_1 TESTS
            //Тесты для экземпляров и методов структуры
            lesson3Tasks.Complex expectedStructValue;
            lesson3Tasks.Complex actualStructValue;
            lesson3Tasks.Complex structTestOperand_1;
            lesson3Tasks.Complex structTestOperand_2;
            
            //TESTS FOR PLUS METHOD
            expectedStructValue = new lesson3Tasks.Complex(4, 6);
            structTestOperand_1 = new lesson3Tasks.Complex(3, 2);
            structTestOperand_2 = new lesson3Tasks.Complex(1, 4);
            actualStructValue = structTestOperand_1.Plus(structTestOperand_2);

            StructElemAreEqual(expectedStructValue, actualStructValue);
            
            expectedStructValue = new lesson3Tasks.Complex(-12, 0);
            structTestOperand_1 = new lesson3Tasks.Complex(0, 2);
            structTestOperand_2 = new lesson3Tasks.Complex(-12, -2);
            actualStructValue = structTestOperand_1.Plus(structTestOperand_2);

            StructElemAreEqual(expectedStructValue, actualStructValue);
            //TESTS FOR MULTIPLY METHOD
            expectedStructValue = new lesson3Tasks.Complex(-40, 18);
            structTestOperand_1 = new lesson3Tasks.Complex(3, 2);
            structTestOperand_2 = new lesson3Tasks.Complex(-12, -2);
            actualStructValue = structTestOperand_1.Multiply(structTestOperand_2);

            StructElemAreEqual(expectedStructValue, actualStructValue);
            //TESTS FOR SUBSTRACT METHOD
            expectedStructValue = new lesson3Tasks.Complex(15, 4);
            structTestOperand_1 = new lesson3Tasks.Complex(3, 2);
            structTestOperand_2 = new lesson3Tasks.Complex(-12, -2);
            actualStructValue = structTestOperand_1.Substraction(structTestOperand_2);

            StructElemAreEqual(expectedStructValue, actualStructValue);
            //
            //
            //Тесты для методов и объектов класса
            lesson3Tasks.ComplexAsClass  expectedClassValue;
            lesson3Tasks.ComplexAsClass actualClassValue;
            lesson3Tasks.ComplexAsClass classTestOperand_1;
            lesson3Tasks.ComplexAsClass classTestOperand_2;

            //TESTS FOR PLUS METHOD
            expectedClassValue = new lesson3Tasks.ComplexAsClass(3, -43);
            classTestOperand_1 = new lesson3Tasks.ComplexAsClass(2, 2);
            classTestOperand_2 = new lesson3Tasks.ComplexAsClass(1, -45);
            actualClassValue = classTestOperand_1.Plus(classTestOperand_2);

            ClassElemAreEqual(expectedClassValue, actualClassValue);
            //TESTS FOR MULTIPLY METHOD
            expectedClassValue = new lesson3Tasks.ComplexAsClass(-88, -92);
            classTestOperand_1 = new lesson3Tasks.ComplexAsClass(2, 2);
            classTestOperand_2 = new lesson3Tasks.ComplexAsClass(1, -45);
            actualClassValue = classTestOperand_1.Multiply(classTestOperand_2);

            ClassElemAreEqual(expectedClassValue, actualClassValue);
            //TESTS FOR SUBSTRACT METHOD
            expectedClassValue = new lesson3Tasks.ComplexAsClass(1, 47);
            classTestOperand_1 = new lesson3Tasks.ComplexAsClass(2, 2);
            classTestOperand_2 = new lesson3Tasks.ComplexAsClass(1, -45);
            actualClassValue = classTestOperand_1.Substraction(classTestOperand_2);

            ClassElemAreEqual(expectedClassValue, actualClassValue);
            #endregion END TASK_1 TESTS


            #region TASK_3 TESTS
            //Inicialize class exemplars
            lesson3Tasks.Fraction expectedFractionValue;
            lesson3Tasks.Fraction actualFractionValue;
            lesson3Tasks.Fraction FractionTestOperand_1;
            lesson3Tasks.Fraction FractionTestOperand_2;

                #region PLUS METHOD TESTS

                expectedFractionValue = new lesson3Tasks.Fraction(2, 13, 2);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(17, 13);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(11, 13);
                actualFractionValue = FractionTestOperand_1.Plus(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(26, 45);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(23, 45);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(3, 45);
                actualFractionValue = FractionTestOperand_1.Plus(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(9, 10);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(2, 4);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(2, 5);
                actualFractionValue = FractionTestOperand_1.Plus(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(-12, 23);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(-7, 23);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(-5, 23);
                actualFractionValue = FractionTestOperand_1.Plus(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(2);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(1,2);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(3,2);
                actualFractionValue = FractionTestOperand_1.Plus(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(-1, 10);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(-3, 5);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(1, 2);
                actualFractionValue = FractionTestOperand_1.Plus(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                #endregion

                #region TESTS FOR METHOD SUBSTRACT

                expectedFractionValue = new lesson3Tasks.Fraction(7, 13, -1);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(-23, 13);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(-3, 13);
                actualFractionValue = FractionTestOperand_1.Substraction(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(1, 10, -1);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(-3, 5);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(1, 2);
                actualFractionValue = FractionTestOperand_1.Substraction(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(1,3,1);
             FractionTestOperand_1 = new lesson3Tasks.Fraction(2, 3,2);
             FractionTestOperand_2 = new lesson3Tasks.Fraction(1, 3,1);
             actualFractionValue = FractionTestOperand_1.Substraction(FractionTestOperand_2);

             FractionAreEqual(expectedFractionValue, actualFractionValue);

             expectedFractionValue = new lesson3Tasks.Fraction(17,26,-1);
             FractionTestOperand_1 = new lesson3Tasks.Fraction(-23, 13);
             FractionTestOperand_2 = new lesson3Tasks.Fraction(-3, 26);
             actualFractionValue = FractionTestOperand_1.Substraction(FractionTestOperand_2);

             FractionAreEqual(expectedFractionValue, actualFractionValue);
                #endregion

                #region TESTS FOR METHOD MULTIPLY

                expectedFractionValue = new lesson3Tasks.Fraction(55,184);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(5, 8);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(11, 23);
                actualFractionValue = FractionTestOperand_1.Multiply(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(3,5);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(-4, 5);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(-3, 4);
                actualFractionValue = FractionTestOperand_1.Multiply(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(1,14,-1);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(10, 7);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(-3, 4);
                actualFractionValue = FractionTestOperand_1.Multiply(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(1,2,5);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(1,2,1);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(2,3,3);
                actualFractionValue = FractionTestOperand_1.Multiply(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                #endregion

                #region TESTS FOR METHOD DIVIDE

                expectedFractionValue = new lesson3Tasks.Fraction(7,20,1);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(3,5);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(4,9);
                actualFractionValue = FractionTestOperand_1.Divide(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(18,35);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(4,5,1);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(1,2,3);
                actualFractionValue = FractionTestOperand_1.Divide(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(1,2);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(1,1);
                FractionTestOperand_2 = new lesson3Tasks.Fraction(2,1);
                actualFractionValue = FractionTestOperand_1.Divide(FractionTestOperand_2);

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                #endregion

                #region TEST ToSimple METHOD

                expectedFractionValue = new lesson3Tasks.Fraction(1,2);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(2,4);
                actualFractionValue = FractionTestOperand_1.ToSimple();

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(-4, 5);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(-12, 15);
                actualFractionValue = FractionTestOperand_1.ToSimple();

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                expectedFractionValue = new lesson3Tasks.Fraction(2,3,2);
                FractionTestOperand_1 = new lesson3Tasks.Fraction(8,3);
                actualFractionValue = FractionTestOperand_1.ToSimple();

                FractionAreEqual(expectedFractionValue, actualFractionValue);

                #endregion

                //END TEST


                #endregion


            }
            catch (DivideByZeroException)
            {
            }
        }
    }
}
