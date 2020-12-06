using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{//Burashnikov Sergey

    public class Lesson2Tasks
    {
        #region Task1
        //Написать метод, возвращающий минимальное из трёх чисел.
        public static double threeNumMin(double var_1, double var_2, double var_3)
        {
            double min = var_1; //Заранее определили, что минимальное число - первое
            if (min >= var_2 || min >= var_3)        //Здесь сравниваем наш "минимум" с остальными числами
            {
                min = var_2 >= var_3 ? var_3 : var_2;   //Если 1 число не минимум, то определяем, какое из других двух меньше
            }
            return min;
        }
        #endregion

        #region Task2
        //Написать метод подсчета количества цифр числа.

        public static int numeralCountInNumber(double num) //Использовал решение в виде явного преобразования в строку
        {
            int counter = Convert.ToString(num).Length;

            string numToString = Convert.ToString(num);

            if (numToString.Contains(',')) return counter - 1; //Определяем, является ли число вещественным, если да, то ведем подсчет
            else return counter;                                //без разделителя "запятая" дробной и целой части
        }
        #endregion

        #region Task3
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        public static int oddPositiveNumCounter()
        {
            int compareNum;
            int counter = 0;
            Console.WriteLine("Для подсчета нечетных положительных чисел, вводите их подряд  после каждого числа, " +
                "нажимая Enter. \n Для остановки подсчета введите 0.");
            do
            {
                compareNum = Convert.ToInt32(Console.ReadLine());
                if (compareNum % 2 != 0 && compareNum > 0) counter++;

            }
            while (compareNum != 0);




            return counter;
        }
        #endregion

        #region Task4
        /*Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. 
            На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            Используя метод проверки логина и пароля, написать программу: 
            пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            С помощью цикла do while ограничить ввод пароля тремя попытками.*/

        public static bool checkLogin()
        {
            string login = "root";
            string password = "GeekBrains";
            int tryCounter = 0;
            string userLogin;
            string userPassword;
            bool checkResult = true;

            do
            {
                Console.Write("Enter your login: ");
                userLogin = Console.ReadLine();
                Console.Write("Enter your password: ");
                userPassword = Console.ReadLine();

                if (login != userLogin || password != userPassword)
                {
                    checkResult = false;
                }
                else { checkResult = true; break; }

                tryCounter++;
            }
            while (tryCounter != 3);

            return checkResult;
        }

        #endregion

        #region Task5
        /*а) Написать программу, которая запрашивает массу и рост человека, вычисляет 
         * его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/


        public static double[] simpleBMI() //Доработанный метод из Lesson-1, теперь возвращает массив параметров пользователя
        {
            Console.WriteLine("Enter your height (m)");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your weight(kg)");
            int weight = Convert.ToInt32(Console.ReadLine());
            int BMI = (int)(weight / Math.Pow(height, 2));

            double[] resArr = new double[3] { weight, height, BMI };//Понадобится в BMI_Assistant() для вывода кг на которые нужно изменить вес

            return resArr;

        }
        //Дополнительная функция расчета BMI, чтобы была возможность в BMI_Assistant() рассчитать новый BMI с учетом изменения веса
        public static double BMI_function(double userHeight, double userWeight, double userBMI)
        {
            double newBMI = userWeight / Math.Pow(userHeight, 2);
            return newBMI;
        }

        public static string BMI_Assistant()
        {
            int i = 0;
            double[] arr = new double[3];
            foreach (double elem in simpleBMI()) //Наполняем массив параметров пользователя параметрами из simpleBMI()
            {
                arr[i] = elem;
                i++;
            }

            string advice;
            double tolerance = arr[0];

            if (arr[2] < 12 || arr[2] >= 12 && arr[2] <= 19)//Если индекс меньше нормы
            {
                while (arr[2] <= 19)//то приводим его в норму с помощью цикла, выполняемого до достижения минимально допустимой нормы
                {
                    arr[0]++; 
                    arr[2] = BMI_function(arr[1], arr[0], arr[2]); //Вызваем функцию подсчета индека с измененным параметром массы
                }
                advice = "Рекомендуем набрать вес, минимум на " + (arr[0] - tolerance) + " кг"; //показываем пользователю, сколько кг нужно набрать
            }
            else if (arr[2] > 19 && arr[2] <= 25) { advice = "Ваш вес в норме"; } //Если индекс в норме
            else if (arr[2] > 25 && arr[2] <= 29) //Если немного превышен индекс
            {
                while (arr[2] > 25) //Аналогия с первым while: здесь работаем на "сброс" кг
                {
                    arr[0]--;
                    arr[2] = BMI_function(arr[1], arr[0], arr[2]);
                }
                advice = "Рекомендуем немного снизить вес минимум на " + (tolerance - arr[0]) + " кг";
            }
            else
            {
                while (arr[2] > 25)
                {
                    arr[0]--;
                    arr[2] = BMI_function(arr[1], arr[0], arr[2]);
                }
                advice = "Серьезное превышение веса. Рекомендуем снизить вес минимум на " + (tolerance - arr[0]) + " кг";
            }
            return advice;
        }
        #endregion

        #region Task6
        /**Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            «Хорошим» называется число, которое делится на сумму своих цифр.
            Реализовать подсчёт времени выполнения программы, используя структуру DateTime.*/

        public static int goodNumCounter(int lowDistBorder, int highDistBorder)
        {
            DateTime start = DateTime.Now;
            int count = 0;

            for (int number = lowDistBorder; number <= highDistBorder; number++)
            {
                int numeralSummary = 0;
                string numToString = Convert.ToString(number);
                foreach(char numeral in numToString)
                {
                    numeralSummary += (numeral - '0'); //т.к. при выборке char и так будет числом, избавляемся от его символьной части
                }
                if(number % numeralSummary == 0) count++;
            }

            Console.WriteLine(DateTime.Now - start);
            return count;
        }
        #endregion

        #region Task7
        /*a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*/

        //Реализуем вывод в одном методе с помощью передачи необязательного (при первом вызове) параметра суммы
        public static void writeAndSumm(int lowBorder, int highBorder, int summary = 0) 
        {
                if (lowBorder > highBorder) return; //Напишем конструкцию выхода из рекурсии

                summary += lowBorder;
                Console.WriteLine("Текущее число: {0}, сумма выведенных чисел = {1}", lowBorder, summary);
                lowBorder += 1;
                writeAndSumm(lowBorder, highBorder, summary); //рекурсия с новыми параметрами суммы и нижней границы
            
        }
        #endregion

        static void Main(string[] args)
        {
            //Console.WriteLine(oddPositiveNumCounter()); //Тест для метода Task3 без параметров, не знаю как такой обработать в UnitTest
            //Console.WriteLine(checkLogin());      //Как работать с консолью в unit tests??? Test Для Task4

            //Console.WriteLine(BMI_Assistant()); //Тест для Task5
            //Console.WriteLine(goodNumCounter(1,1000000)); //Для просмотра времени работы метода

            //writeAndSumm(1,10);   //Тест для task7

        }
    }
    
}
