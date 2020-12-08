using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonTasks
{

    public class lesson3Tasks
    {
        #region TASK_1
        //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
        //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
        //в) Добавить диалог с использованием switch демонстрирующий работу класса.

        public struct Complex
        {
            public double re;
            public double im;

            public Complex(double _re, double _im) //Конструктор с параметрами
            {
                this.re = _re;
                this.im = _im;
            }

            public Complex Plus(Complex operand)//Метод для сложения комплексных чисел
            {
                Complex result = new Complex();
                result.re = this.re + operand.re;
                result.im = this.im + operand.im;
                return result;
            }

            public Complex Multiply(Complex operand)//Метод для умножения комплексных чисел
            {
                Complex result = new Complex();
                result.re = this.re * operand.re + this.im * operand.im;
                result.im = this.re * operand.im - this.im * operand.re;
                return result;
            }

            public Complex Substraction(Complex operand)//Метод для вычитания комплексных чисел
            {
                Complex result = new Complex();
                result.re = this.re - operand.re;
                result.im = this.im - operand.im;
                return result;
            }
        }

        public class ComplexAsClass
        {
            public double _re;
            public double _im;

            public ComplexAsClass(double _re, double _im) //Конструктор с параметрами
            {
                this._re = _re;
                this._im = _im;
            }

            public ComplexAsClass()//Объявленный конструктор по умолчанию
            {

            }

            public double imChange //Свойство для доступа к мнимой части комплексного числа
            {
                get { return this._im; }
                set
                {
                    this._im = value;
                }
            }

            public double reChange//Свойство для доступа к действительно части комплексного числа
            {
                get { return this._re; }
                set
                {
                    this._re = value;
                }
            }
            public ComplexAsClass Plus(ComplexAsClass operand) //Метод сложения комплексных чисел
            {
                ComplexAsClass result = new ComplexAsClass();
                result._re = this._re + operand._re;
                result._im = this._im + operand._im;
                return result;
            }

            public ComplexAsClass Multiply(ComplexAsClass operand) //Метод для умножения комплексных чисел
            {
                ComplexAsClass result = new ComplexAsClass();
                result._re = this._re * operand._re + this._im * operand._im;
                result._im = this._re * operand._im - this._im * operand._re;
                return result;
            }

            public ComplexAsClass Substraction(ComplexAsClass operand)//Метод для вычитания комплексных чисел
            {
                ComplexAsClass result = new ComplexAsClass();
                result._re = this._re - operand._re;
                result._im = this._im - operand._im;
                return result;
            }

            public override string ToString() //Перегруженный метод строкового представления комплексного числа (для вывода в консоль)
            {
                return this._re + " + " + this._im + "i";
            }
        }
        #endregion

        #region TASK_2

        //а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
        //Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse.

        static void oddPositiveNumSummary() 
        {
            int sum = 0;
            int num;
            string input;
            bool indicator;
            int[] oddPositiveArr = new int[0];               //Инициализация массива для хранения неч. полож. чисел
            int oddPosititveArrLenght = oddPositiveArr.Length;

            Console.WriteLine("Чтобы подсчитать сумму нечетных положительных чисел, вводите их с клавиатуры. \n" +
               "Каждый раз после ввода числа нажимайте Enter.\n" +
               "Чтобы прекратить подсчет и увидеть результаты, введите 0");

            do
            {
                input = Console.ReadLine();
                indicator = int.TryParse(input, out num); 
                if (indicator == true)                      //Если строку можно перевести в число
                {
                    num = int.Parse(input);                 //Конвертация строки в Int
                    if (num % 2 != 0 && num > 0)            //Если число неч. положительное
                    {
                        oddPosititveArrLenght++;            //Увеличиваем длину массива на 1
                        sum += num;                         //Записываем в сумму только что проконвертированное число
                        Array.Resize(ref oddPositiveArr, oddPosititveArrLenght);        //Переопределяем размер массива, фактически делая его динамическим
                        oddPositiveArr[oddPosititveArrLenght - 1] = num;                //Записываем в массив конвертированное число
                    }
                    
                }
            } while (num != 0);

            var output = string.Join(" ", oddPositiveArr);          //Инициализируем переменную, содержащую элементы нашего массива для вывода в консоль
            Console.WriteLine($"Из введенных вами чисел нечетными положительными являются:\n" +
                        $"{output}, а их сумма равна:\n" +
                        $"{sum}");
        }
        #endregion

        #region TASK_3
        //*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
        //    Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
        //    Написать программу, демонстрирующую все разработанные элементы класса.
        //* Добавить свойства типа int для доступа к числителю и знаменателю;
        //* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
        //** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        //*** Добавить упрощение дробей.

        public class Fraction
        {
            private int nominator;
            private int denominator;
            private int intPart;         //Дополнительно объявляем параметр, обозначающий целую часть дроби (for example: две целых четыре пятых)
            public Fraction()           //Объявление конструктора по умолчанию
            {

            }

            public Fraction(int intPart)        //Объявление конструктора дроби, которая является целым числом (в рамках данной реализации используется
            {                                   //вместе с методами класса и в тестах)
                this.intPart = intPart;
            }

            public Fraction(int nominator, int denominator, int intPart=0)          //Конструктор с параметрами, в котором дробь может и не иметь целой части
            {                                                                       
                try
                {
                    if (denominator == 0)
                    {
                        throw new ArgumentException();          //Выбрасывание исключения ArgumentException, если знаменталь == 0
                    }                                           //Исключение DivideByZero обрабатывается в методе lesson3Tests.Main() 

                    this.nominator = nominator;
                    this.denominator = denominator;
                    this.intPart = intPart;

                }
                catch(ArgumentException)
                {
                    Console.WriteLine($"Знаменатель не может быть равен 0");            

                }
            }

            public int nomiChange           //Свойство для достпуа к числителю
            {
                get {return this.nominator; }
                set
                {
                    this.nominator = value;
                }
            }
            public int denomiChange         //Свойство для доступа к знаменателю
            {
                get { return this.denominator; }
                set
                {   if (this.denominator != 0)
                        this.denominator = value;
                    else throw new ArgumentException(String.Format("Знаменатель не может быть равен 0"));
                }
            }

            public double DecimalPart           //Свойство для чтения десятичной дроби числа
            {
                get { return (double)nominator / denominator; }
            }

            public int _IntPart          //Свойство для чтения целой части числа
            {
                get { return this.intPart; }
                set
                {
                    this.intPart = value;
                }
            }



            //Метод сложения дробей, возвращающий сокращенную(если возможно) дробь
            //Числители слагаемых всегда домножается на целую часть числа, сделано для дальнейшего корректного вычисления
            //(for example: 2 целых две третьих == восемь третьих)
            public Fraction Plus(Fraction operand)  
            {
                Fraction result = new Fraction();
                if (this.denominator != operand.denominator )
                {
                    result.nominator = (this.nominator + this.denominator*this.intPart)* operand.denominator 
                        + 
                    this.denominator * (operand.nominator + operand.intPart*operand.denominator);

                    result.denominator = this.denominator * operand.denominator;   
                }
                else
                {
                    result.nominator = this.nominator + this.denominator * this.intPart + operand.nominator + operand.intPart * operand.denominator;
                    result.denominator = this.denominator;
                }
                return result.ToSimple();
            }


            //Метод вычитания дробей, возвращающий сокращенную(если возможно) дробь
            //Числители вычитаемого всегда домножается на целую часть числа, сделано для дальнейшего корректного вычисления
            //(for example: 2 целых две третьих == восемь третьих)
            public Fraction Substraction(Fraction operand)
            {
                Fraction result = new Fraction();
                if (this.denominator != operand.denominator)
                {
                    result.nominator = (this.nominator + this.denominator * this.intPart) * operand.denominator 
                        -
                        this.denominator * (operand.nominator + operand.intPart * operand.denominator);
                    result.denominator = this.denominator * operand.denominator;
                }
                else
                {
                    result.nominator = (this.nominator + this.denominator * this.intPart) - (operand.nominator + operand.intPart * operand.denominator);
                    result.denominator = this.denominator;
                }
                return result.ToSimple();
            }


            //Метод умножения дробей, возвращающий сокращенную(если возможно) дробь
            //Числители множителей всегда домножается на целую часть числа, сделано для дальнейшего корректного вычисления
            //(for example: 2 целых две третьих == восемь третьих)
            public Fraction Multiply(Fraction operand)
            {
                Fraction result = new Fraction((this.nominator+this.intPart*this.denominator)*(operand.nominator+operand.intPart*operand.denominator),
                    this.denominator*operand.denominator);
                
                return result.ToSimple();
            }

            //Метод деления дробей, возвращающий сокращенную(если возможно) дробь
            //Числители вычитаемого всегда домножается на целую часть числа, сделано для дальнейшего корректного вычисления
            //(for example: 2 целых две третьих == восемь третьих)
            public Fraction Divide(Fraction operand)
            {
                Fraction result = new Fraction((this.nominator+this.intPart*this.denominator) * operand.denominator, 
                    this.denominator * (operand.nominator+operand.intPart*operand.denominator));
                
                return result.ToSimple();
            }



            /*
             * WARNING! Возможны "костыли" в коде
            */

            //Метод упрощения (скоращения дробей)
            //Реализация метода включает: поиск НОД по алгоритму Евклида
            //Запись в целую часть, если модуль числителя больше модуля знаменателя
            public Fraction ToSimple()
            {
                Fraction result;
                int NOD;
                int dividend = Math.Abs(this.nominator);        //Переменные Dividend и Divider - буферные, чтобы не происходило перезаписи
                int divider = Math.Abs(this.denominator);       //данных в значимых переменных и в алгоритме не учитывался знак числа
                int fractionMultiplier = this.intPart;          //"Костыль"(?) для обработки целой части числа

                                                            #region Пояснение
                                                            //До внедрения переменной fractionMultiplier для храниения целой части дроби в строках 

                                                            //   fractionMultiplier = result.nominator / result.denominator;
                                                            //   result.nominator = Math.Abs(result.nominator) - Math.Abs(fractionMultiplier * result.denominator);

                                                            //значение result.intPart всегда прибавлялось к result.nominator
                                                            //Прошлый вариант:
                                                            //  result.intPart = result.nominator / result.denominator;
                                                            //  result.nominator = Math.Abs(result.nominator) - Math.Abs(fractionMultiplier * result.denominator);


                                                            //    к числителю дроби и дальнейшие вычисления были некорректны.

                                                            #endregion


                while ((dividend != 0) && (divider != 0)) //Реализация алгоритма Евклида
                {
                    if (dividend > divider)
                        dividend %= divider;
                    else
                        divider %= dividend;
                }
                 NOD = Math.Max(dividend, divider); 

                if (NOD != 1)  //Если НОД != 1
                { 
                    //То результирующая дробь == сократимая дробь.
                    //Использование intPart в качестве необязательного параметра конструктора позволяет обрабатывать intPart == 0
                    result = new Fraction(this.nominator / NOD, this.denominator / NOD, fractionMultiplier);    

                }//Если НОД == 1
                // То вовзращаем исходную дробь
                else  result = new Fraction(this.nominator,this.denominator,fractionMultiplier);


                //Если после упрощения дроби числитель остался больше знаменателя, нужно выделить целую часть
                if (Math.Abs(result.nominator) > Math.Abs(result.denominator))
                {
                    fractionMultiplier = result.nominator / result.denominator;
                    result.nominator = Math.Abs(result.nominator) - Math.Abs(fractionMultiplier*result.denominator);
                    result.intPart = fractionMultiplier;
                    return result = new Fraction(result.nominator,result.denominator,result.intPart);
                }
                else if (result.nominator == result.denominator) //Обработка значения 1/1
                    return result = new Fraction(result.nominator / result.denominator); //Запись "1" в конструктор цедой части
                else return result;
            }


            //Метод для строкового представления дроби
            //Принял решение в случае наличия целой части конкатенировать с амперсандом
            public override string ToString()
            {
                if (this.intPart == 0) return this.nominator + "/" + this.denominator;  //(For example:  11/18 == Одиннадцать восемнадцатых)
                else if (this.nominator == 0) return Convert.ToString(this.intPart);    //(for example:  2 == Две целых == Два)
                else return this.intPart +"&"+ this.nominator + "/" + this.denominator; //(For example:  3&42/228 == Три целых сорок две двести двадцать восьмых)
            }

                    
        }


        #endregion
        static void Main(string[] args)
        {
            #region Демострация метода switch с классом ComplexAsClass TASK_1
            string inputCompNum_1;
            string inputCompNum_2;
            string userChoise;
            int convertToSwitchCases;
            ComplexAsClass num_1 = new ComplexAsClass();
            ComplexAsClass num_2 = new ComplexAsClass();

            do
            {
                Console.WriteLine("Введите два комплексных числа по очереди. \n" +
                "Пример: \n" +
                "3 6 далее нажмите Enter и введите целую и мнимую часть второго числа. \n" +
                "Если хотите остановиться: введите q, когда пожелаете.");
                inputCompNum_1 = Console.ReadLine();
                if (inputCompNum_1.Contains('q') == true) break;   //Позволяем пользователю прервать подсчеты на любой стадии ввода
                inputCompNum_2 = Console.ReadLine();
                if (inputCompNum_2.Contains('q') == true) break;

                num_1 = new ComplexAsClass(inputCompNum_1[0] - '0', inputCompNum_1[2] - '0');   //Переводим из строки(==массива символов)
                num_2 = new ComplexAsClass(inputCompNum_2[0] - '0', inputCompNum_2[2] - '0');   //в части комплексного числа, избавлясь от символьного остатка

                Console.WriteLine("Что необходимо сделать с этими числами?");
                userChoise = Console.ReadLine().ToLower().Trim();  //Нивеллируем возможные варианты/ошибки при вводе


                //Записываем в switch-кейсы, что нужно пользователю
                if (userChoise.Contains("слож") || userChoise.Contains('+')) convertToSwitchCases = 1;
                else if (userChoise.Contains("множ") || userChoise.Contains('*')) convertToSwitchCases = 2;
                else if (userChoise.Contains("выч") || userChoise.Contains('-')) convertToSwitchCases = 3;
                else break;

                switch (convertToSwitchCases)
                {
                    case 1:
                        {
                            Console.WriteLine((num_1.Plus(num_2)).ToString());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine((num_1.Multiply(num_2)).ToString());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine((num_1.Substraction(num_2)).ToString());
                            break;
                        }
                }

            } while (true);         //Так как предоставили возможность пользователю прервать 
                                    //выполение программы во время ввода, избавились от необходимости управлять циклом условием
            #endregion

            // Task2 test
            oddPositiveNumSummary();
        }
    }
}
