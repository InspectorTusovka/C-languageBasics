using delegatesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson6_Tasks
{
    class TestMethods
    {
        static void Main()
        {
            #region TASK_1 Demonstration
            Console.WriteLine("Таблица функции a*x^2:");
            SimpleFuncTable.Table(SimpleFuncTable.PowConst, -2, 1, 2);

            Console.WriteLine("Таблица функции a*Sin(x):");
            SimpleFuncTable.Table(SimpleFuncTable.Sinusoide, -2, 5, 2);
            #endregion

            Console.WriteLine();


            #region TASK_3 Demonstration
            foreach (StudentList student in StudentList.Age_CourseSort(StudentList.FileReader()))
            {
                Console.WriteLine($"{student.GetLastname} {student.GetName} {student.GetUniversity} {student.GetAge} {student.GetCourse}");
            }
            Console.WriteLine();
            StudentList.StudentCoursesCounter(StudentList.FileReader());
            Console.WriteLine();

            List<StudentList> st = StudentList.FileReader();
            StudentList.Age_CourseSort(st);
            Dictionary<int, int> tr = StudentList.StudentsInfo(st);
            foreach (int key in tr.Keys.ToList())
            {
                Console.WriteLine($"Студентов учащихся на {key} курсе:  {tr[key]} человек.");
            }
            #endregion

        }
    }
}

