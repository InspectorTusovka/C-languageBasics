using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace delegatesLibrary
{
    public delegate double Fun(double var_X, double const_A);
    #region TASK_1

    //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

    public class SimpleFuncTable
    {

        public static void Table(Fun F, double x, double a, double b)
        {
            Console.WriteLine("----- X --------- Y --------- A -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", x, F(x, a), a);
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double PowConst(double x, double a)
        {
            return a * (Math.Pow(x, 2));
        }
        public static double Sinusoide(double x, double a)
        {
            return a * Math.Sin(x);
        }

    }
    #endregion

    #region TASK_3
    //Переделать программу Пример использования коллекций для решения следующих задач:
    //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
    //    в) отсортировать список по возрасту студента;
    //г) * отсортировать список по курсу и возрасту студента;


    //Вспомогательный класс содержащий метод сортировки для экземпляров класса StudentList
    public class CollectionMethods
    {

        //Метод обмена значениями между двумя элементами коллекции
        static void Swap(List<StudentList> data, int buff, int i)
        {
            var temp = data[buff];
            data[buff] = data[i];
            data[i] = temp;
        }

        //Обыкновенный BubbleSort дополненный фильтром сортировки (По курсу/по возрасту)
        public static List<StudentList> BubbleSort(List<StudentList> data, string sortFormat)
        {
            var lenght = data.Count;
            if (sortFormat == "course")
            {
                for (var i = 1; i < lenght; i++)
                {
                    for (var j = 0; j < lenght - i; j++)
                    {
                        if (data[j].GetCourse > data[j + 1].GetCourse)
                        {
                            Swap(data, j, j + 1);
                        }
                    }
                }
            }
            else
            {
                for (var i = 1; i < lenght; i++)
                {
                    for (var j = 0; j < lenght - i; j++)
                    {
                        if (data[j].GetAge > data[j + 1].GetAge)
                        {
                            Swap(data, j, j + 1);
                        }
                    }
                }
            }
            return data;
        }


    }

    public class StudentList
    {
        private string _lastName; //Фамилия студента
        private string _name;   //Имя студента
        private string _university;     //Университет студента
        private int _age;   //Возраст студента
        private int _course;    //Курс студента


        //Конструктор с параметрами
        public StudentList(string lastName, string name, string university, int age, int course)
        {
            _lastName = lastName;
            _name = name;
            _university = university;
            _age = age;
            _course = course;
        }

        public string GetLastname       //Свойство доступа к полю Фамилия
        {
            get { return _lastName; }
        }
        public string GetName       //Свойство доступа к полю Имя
        {
            get { return _name; }
        }
        public string GetUniversity       //Свойство доступа к полю Университет
        {
            get { return _university; }
        }
        public int GetAge       //Свойство доступа к полю Возраст
        {
            get { return _age; }
        }
        public int GetCourse       //Свойство доступа к полю Курс
        {
            get { return _course; }
        }

        //Метод считывания информации о студентах из текстового файла
        //Наполняет коллекцию типа List содержащую в себе всех студентов и информацию о них из файла
        public static List<StudentList> FileReader()
        {
            string[] bufStr = new string[5];
            List<StudentList> result = new List<StudentList>();
            StreamReader fileStream = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "studentsList.txt");

            while (!fileStream.EndOfStream)
            {
                bufStr = fileStream.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                StudentList student = new StudentList(bufStr[0], bufStr[1], bufStr[2], int.Parse(bufStr[3]), int.Parse(bufStr[4]));
                result.Add(student);
            }
            fileStream.Close();

            return result;
        }

        //Метод подсчитывающий и выводящий в консоль информацию о количестве студентов на каждом курсе
        public static void StudentCoursesCounter(List<StudentList> inputList)
        {
            int count_1 = 0;
            int count_2 = 0;
            int count_3 = 0;
            int count_4 = 0;
            int count_5 = 0;
            int count_6 = 0;

            foreach (StudentList student in inputList)
            {
                if (student.GetCourse == 1) count_1++;
                else if (student.GetCourse == 2) count_2++;
                else if (student.GetCourse == 3) count_3++;
                else if (student.GetCourse == 4) count_4++;
                else if (student.GetCourse == 5) count_5++;
                else count_6++;
            }

            Console.WriteLine($"Количество учащихся на\n" +
                $"первом курсе: {count_1}\n" +
                $"втором курсе: {count_2}\n" +
                $"третьем курсе: {count_3}\n" +
                $"четвертом курсе: {count_4}\n" +
                $"пятом курсе: {count_5}\n" +
                $"шестом курсе: {count_6}\n");
        }


        //Сортировка экземпляров класса StudentList в коллекции типа List 
        //Сортировка по курсу и возрасту в одном методе
        public static List<StudentList> Age_CourseSort(List<StudentList> unsorted)
        {
            CollectionMethods.BubbleSort(unsorted, "course");       //Сортировка студентов по курсу
            Dictionary<int, List<StudentList>> sortBuff = new Dictionary<int, List<StudentList>>();     //Словарь содержащий в себе экземпляры класса StudentList в парах (ключ==Курс;значение==Студенты этого курса

            //Наполнение словаря экземплярами класса
            for (int i = 1; i <= 6; i++)
            {
                foreach (StudentList student in unsorted)
                {
                    if (student.GetCourse == i)
                    {
                        if (sortBuff.ContainsKey(i)) sortBuff[i].Add(student);
                        else sortBuff[i] = new List<StudentList> { student };
                    }
                }
            }

            unsorted.Clear();   //Работу по сортировке проведем в исходной коллекции List, поэтому очистим ее

            //И наполним уже отсортированными по курсу и возрасту экземплярами
            foreach (int key in sortBuff.Keys.ToList())
            {
                CollectionMethods.BubbleSort(sortBuff[key], "age");
                foreach (StudentList student in sortBuff[key])
                {
                    unsorted.Add(student);
                }
            }
            return unsorted;
        }


        //Метод подсчета количества студентов 18-20 лет учащихся на каждом курсе
        public static Dictionary<int, int> StudentsInfo(List<StudentList> request)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int course = 1; course <= 6; course++)
            {
                foreach (StudentList student in request)
                {
                    if (student.GetAge >= 18 && student.GetAge <= 20 && student.GetCourse == course)
                    {
                        if (result.ContainsKey(course)) result[course]++;
                        else result.Add(course, 1);
                    }
                }
            }
            return result;

        }
    }
    #endregion
}