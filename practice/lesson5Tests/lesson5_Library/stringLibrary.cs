using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace lesson5_Library
{
    public class stringLibrary
    {
        #region TASK_1
        //Создать программу, которая будет проверять корректность ввода логина.
        //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        //а) без использования регулярных выражений;
        //б) **с использованием регулярных выражений.


        //Метод проверки логина на корректный ввод без использования регулярных выражений
        public static string CheckLogin_NoRegex()
        {
            Console.Write($"Введите свой логин: ");
            string userLogin = Console.ReadLine();
            if (userLogin.Length < 2 || userLogin.Length > 10)
            {
                return ($"Неверная длина логина. Логин должен содержать от 2 до 10 символов");
            }
            if (Char.IsDigit(userLogin[0]))
            {
                return ($"Логин не может начинаться с цифры.");
            }
            for (int i = 0; i < userLogin.Length; i++)
            {

                if (userLogin[i] < '0' || (userLogin[i] > '9' && userLogin[i] < 'A') || (userLogin[i] > 'Z' && userLogin[i] < 'a') || userLogin[i] > 'z')
                {
                    return ($"Логин может содержать только буквы латинского алфавита или цифры");
                }
            }
            return ($"Добро пожаловть, {userLogin}");
        }

        //Метод проверки логина с использованием регулярного выражения
        public static void CheckLogin_Regex()
        {
            Regex regex = new Regex(@"^[^0-9]{1}[A-Za-z0-9]{2,9}$");
            Console.Write($"Введите свой логин: ");
            string userLogin = Console.ReadLine();

            if (regex.IsMatch(userLogin)) Console.WriteLine($"Welcome, {userLogin}!");
            else Console.WriteLine($"Логин должен содержать от 2 до 10 букв латинского алфавита или цифр, не должен начинаться с цифры");

        }
        #endregion

        #region TASK_3
        //*   Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        //    Например:
        //    badc являются перестановкой abcd.


        //Реализация основана на проверке идентичности сумм хеш-кодов символов строки
        public static bool CheckTranspositon(string strA, string strB)
        {
            int hashSumStrA = 0;
            int hashSumStrB = 0;
            for (int i = 0; i < strA.Length; i++)
            {
                hashSumStrA += strA[i].GetHashCode();
            }
            for (int i = 0; i < strB.Length; i++)
            {
                hashSumStrB += strB[i].GetHashCode();
            }
            if (hashSumStrA == hashSumStrB) return true;
            else return false;
        }

        #endregion
    }
    #region TASK_2
    //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения,  которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, 
    //в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.

    public static class Message
    {
        //Определение массива разделителей строки
        private static string[] separators = new string[] { ",", ".", "/", "\\", "\'", ";", "\"", "]", "}", "[", "{", "?", "!", "@", "#", "%", "^", ":", "-", " " };

        //Метод вывода в консоль тех и только тех слов, в которых n или меньше букв
        public static void Get_N_LettersWord(string text, int wordLenght)
        {
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"В словах: ");
            foreach (string word in words)
            {
                if (word.Length <= wordLenght)
                {
                    Console.WriteLine($"{word}");
                }
            }
            Console.WriteLine($"{wordLenght} или меньше букв");
        }


        //Метод удаляющий из текста все слова оканчивающиеся на определенную букву
        //Реализовано на классе StringBuilder
        public static StringBuilder RemoveWords(string inputStr, char symbol)
        {
            StringBuilder result = new StringBuilder(inputStr);
            string[] words = inputStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (word[word.Length - 1] == symbol) result.Replace(word, string.Empty);        //Заменяем на пустую строку, не контролируется задвоение символа пробела
            }
            return result;
        }


        //Метод возвращающий строку класса StringBuilder из самых длинных слов текста
        public static StringBuilder TextLongestWords(string inputStr)
        {
            StringBuilder result = new StringBuilder();
            string[] words = inputStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string longest = words[0];
            foreach (string _word in words)
            {
                if (_word.Length >= longest.Length)
                {
                    longest = _word;
                }
            }
            foreach (string word in words)
            {
                if (word.Length == longest.Length) result.Append(word + ", ");
            }
            return result;
        }


        //Вспомогательный метод-аналог Contains(). Определяет насколько сравниваемое слово походит на эквивалентное
        //Служит для "узнавания" слова. Например, если слово изменилось в тексте в результате склонения в падеж, множ. число и др.
        public static bool ContainsPercentage(string strA, string strB)
        {
            double percent = 0;
            bool flag = false;
            double minLenght = (strA.Length < strB.Length) ? strA.Length : strB.Length;
            double percentIncrement = 100.00 / minLenght;
            for (int i = 0; i < minLenght; i++)
            {
                if (strA[i] == strB[i])
                {
                    percent += percentIncrement;
                }
                if (percent >= 75 && Math.Abs(strA.Length - strB.Length) <= 2)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        //В рамках данной реализации исходный текст (предварительно проведенный через .Split()) сортируется по буквам алфавита
        //Необходимо для эффективного частотного анализа текста. Работа проводится в рамках одного ключа типа Char.
        public static Dictionary<char, List<string>> AlphabetSort(string[] unsortText)
        {
            Dictionary<char, List<string>> result = new Dictionary<char, List<string>>();
            foreach (string word in unsortText)     //Простой цикл добавления слов текста в коллекцию по парам типа char(первая буква слова)-list<string>(коллекция слов на эту букву)
            {
                if (result.ContainsKey(word[0]))
                {
                    result[word[0]].Add(word);
                }
                else
                {
                    result[word[0]] = new List<string> { word };
                }
            }
            return result;

        }

        //Метод осуществляющий подсчет числа вхождений требуемых слов в тексте. Возвращает коллекцию Dictionary(слов-число вхождений)
        public static Dictionary<string, int> GetWordFreqeuences(string[] reqWords, string text)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string[] words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<char, List<string>> textAlphabet = AlphabetSort(words);      //Применение к тексту, приведенному к общему стилю, метода сортировки по первым буквам слова
            foreach (char key in textAlphabet.Keys.ToList())
            {
                foreach (string _reqWord in reqWords)
                {
                    if (_reqWord[0] == key)
                    {
                        foreach (string value in textAlphabet[key].ToList())
                        {
                            if (ContainsPercentage(_reqWord, value))    //Применение метода проверки слова на соответствие
                            {
                                if (result.ContainsKey(_reqWord))
                                {
                                    result[_reqWord]++;
                                }
                                else
                                {
                                    result.Add(_reqWord, 1);
                                }
                            }
                        }

                    }
                }
            }
            return result;
        }
    }
    #endregion


    #region TASK_4
    //* Задача ЕГЭ.
    //     На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.В первой строке сообщается количество учеников N, 
    //которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
    //    <Фамилия> <Имя> <оценки>,
    //    где<Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, 
    //<оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе
    //. <Фамилия> и<Имя>, а также<Имя> и<оценки> разделены одним пробелом. Пример входной строки:
    //    Иванов Петр 4 5 3
    //    Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
    //Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.


    //Класс вспомогательных методов для класса Exam
    public class ExamMethods
    {

        //Метод обмена значениями между двумя элементами коллекции
        static void Swap(List<Exam> data, int buff, int i)
        {
            var temp = data[buff];
            data[buff] = data[i];
            data[i] = temp;
        }

        //Обыкновенный BubbleSort
        public static List<Exam> BubbleSort(List<Exam> data)
        {
            var lenght = data.Count;
            for (var i = 1; i < lenght; i++)
            {
                for (var j = 0; j < lenght - i; j++)
                {
                    if (data[j].GetAverage > data[j + 1].GetAverage)
                    {
                        Swap(data, j, j + 1);
                    }
                }
            }
            return data;
        }
    }

    //Класс Exam содержащий поля и методы для обработки информации об учениках и успеваемости
    public class Exam
    {
        private string _lastname;       //Фамилия ученика
        private string _name;           //Имя ученика
        private double _avg;            //Средняя оценка

        public string GetLastname       //Свойство доступа к полю Фамилия
        {
            get { return _lastname; }
        }
        public string GetName           //Свойство доступа к полю Имя
        {
            get { return _name; }
        }
        public double GetAverage        //Свойство доступа к полю Средняя оценка
        {
            get { return _avg; }
        }

        //Конструктор с параметрами. 
        public Exam(string lastname, string name, double average)
        {
            _lastname = lastname;
            _name = name;
            _avg = average;
        }


        //Метод чтения информации об учениках из файла
        //Применен унифицированный Split() (хотя в задании и говорится только о симовлах пробела)
        //В конструктор класса подается уже рассчитанная средняя оценка
        private static List<Exam> FileReader()
        {
            string[] separators = new string[] { ",", ".", "/", "\\", "\'", ";", "\"", "]", "}", "[", "{", "?", "!", "@", "#", "%", "^", ":", "-", " ", "\n", "\t" };
            StreamReader str = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "students_result_2020.txt");
            int studentCount = int.Parse(str.ReadLine());
            List<Exam> dataBase = new List<Exam>();
            string[] currentStudentInfo;

            //Цикл чтения информации об учениках из файла
            while (!str.EndOfStream || studentCount != 0)
            {
                currentStudentInfo = str.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string lastname = currentStudentInfo[0];
                string name = currentStudentInfo[1];
                double average = (double.Parse(currentStudentInfo[2]) + double.Parse(currentStudentInfo[3]) + double.Parse(currentStudentInfo[4])) / 3;
                dataBase.Add(new Exam(lastname, name, average));
                studentCount--;
            }
            str.Close();

            return ExamMethods.BubbleSort(dataBase);    //Перед передачей полученных данных в метод-задание, отсортируем данные в порядке возрастания
        }


        //Метод вывода в консоль трех учеников с худшей стреденй оценкой.
        //Если студентов с одинаковой средней оценкой несколько, то выводит и их
        public static void GetWorstStudents()
        {
            int studentCounter = 1;
            int index = 0;
            List<Exam> data = FileReader();
            Console.WriteLine($"Ученик: {data[index].GetLastname} {data[index].GetName} со средним баллом {data[index].GetAverage:F1}");
            index++;
            while (studentCounter != 3 || data[index].GetAverage == data[index - 1].GetAverage)
            {
                if (data[index].GetAverage == data[index - 1].GetAverage)
                {
                    Console.WriteLine($"Ученик: {data[index].GetLastname} {data[index].GetName} со средним баллом {data[index].GetAverage:F1}");
                }
                else
                {
                    Console.WriteLine($"Ученик: {data[index].GetLastname} {data[index].GetName} со средним баллом {data[index].GetAverage:F1}");
                    studentCounter++;
                }
                index++;
            }
        }
    }
    #endregion
}
