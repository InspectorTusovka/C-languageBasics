using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{// Burashnikov Sergey
    class Program
    {

        #region Task1
        /*Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). 
         * В результате вся информация выводится в одну строчку:
        а) используя склеивание;
        б) используя форматированный вывод;
        в) используя вывод со знаком $.*/
        static void uRWelcome()
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Напишите свой возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("И, наконец, вашу массу");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Have a nice day, " + name + " " + lastname + ".\n" + height + "cm, " + age + " y.o. " + weight + " kg.\n");
            Console.WriteLine("{0:G},{1:G},{2:D},{3:D},{4:F1}", name, lastname, age, height, weight);
            Console.WriteLine($"Name: {name} {lastname} Age: {age} Height: {height}cm Weight: {weight}kg ");
        }
        #endregion

        #region Task2
        //ввести вес и рост человека.рассчитать и вывести индекс массы тела(имт) по формуле i=m/(h* h); 
        //    где m — масса тела в килограммах, h — рост в метрах.
        static double BMI()
        {
            Console.WriteLine("Enter your height (m)");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your weight(kg)");
            double weight = Convert.ToDouble(Console.ReadLine());
            double BMI = weight / Math.Pow(height, 2);
            return BMI;

        }
        #endregion

        #region Task3
        /*а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
         * по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
         * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
        б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/

        static double pointDistance(double x1, double x2, double y1, double y2)
        {
            double radius = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return radius;
        }
        #endregion

        #region Task4
        /*Написать программу обмена значениями двух переменных:
        а) с использованием третьей переменной;
	    б) *без использования третьей переменной.*/
        #endregion
        
        static void Main(string[] args)
        {
            //testTask1 uRWelcome();

            //testTask2 Console.WriteLine("{0:F2}", BMI());

            //testTask3 Console.WriteLine("{0:F2}",pointDistance(4.12,22.54,-123.04,1));

            /*Task4 int varFirst = 123;
            int varSecond = 23;
            int buffer = varFirst;
            varFirst = varSecond;
            varSecond = buffer;*/

        }
    }
}
