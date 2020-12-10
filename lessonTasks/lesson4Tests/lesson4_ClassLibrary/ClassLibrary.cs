using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Collections
{
    #region TASK_2 assosiation with TASK_1

    //Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
    //Заполнить случайными числами.Написать программу, 
    //позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
    //В данной задаче под парой подразумевается два подряд идущих элемента массива.
    //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 


    //Реализуйте задачу 1 в виде статического класса StaticClass;
    //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    //в)** Добавьте обработку ситуации отсутствия файла на диске.


    public static class StaticClass
    {
        public static int[] GetArray()      //Статический метод получения массива [20]
        {
            int[] result = new int[20];
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                result[i] = rand.Next(-10_000, 10_000);
            }
            return result;
        }

        //Обобщим и сделаем так, чтобы метод был унифицированным и работал с любым числом. 
        //Заранее определим, что делитель - параметр необязятальный и в рамках задания
        //назначим его дефолтное значение равным 3 (как требуется)
        public static int DividedByNumber(int[] array, int dividerNum = 3)
        {
            int pairsCounter = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                //Опишем упр. конструкцию, которая обеспечит поиск того, что ТОЛЬКО одни число из пары делится на делитель.
                if ((array[i] % dividerNum == 0 && array[i + 1] % dividerNum != 0) || (array[i] % dividerNum != 0 && array[i + 1] % dividerNum == 0))
                {
                    pairsCounter++;
                }
            }
            return pairsCounter;
        }

        public static int[] ArrayFromTextFile()     //Метод чтения массива из файла(работает только дла элементов разделенных символом
        {                                           // перевода строки. Т.к. reeadline считывает построчно
            int[] resultArray = new int[0];
            int resultArrayLenght = 0;
            int index = 0;

            try
            {
                StreamReader output = new StreamReader("..\\..\\..\\task_1_text_file.txt");
                while (!output.EndOfStream)
                {
                    string bufStr = output.ReadLine();
                    if (int.TryParse(bufStr, out int buffer))
                    {
                        Array.Resize(ref resultArray, ++resultArrayLenght);         //Доработанный динамический массив, теперь выглядит стильно
                        resultArray[index++] = int.Parse(bufStr);                   
                    }
                }
                output.Close();
            }
            catch (FileNotFoundException ex)        //Обработка исключения "Отсутсвия файла по указанному пути"
            {
                String.Format($"FILE NOT FOUND\n{ex.Message}");     //Доп. сообщение об ошибке
            }
            return resultArray;
        }
    }

    #endregion

    #region TASK_3
    //а) Дописать класс для работы с одномерным массивом. 
    // Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
    //     Создать свойство Sum, которое возвращает сумму элементов массива, 
    //     метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  
    //     метод Multi, умножающий каждый элемент массива на определённое число, 
    //     свойство MaxCount, возвращающее количество максимальных элементов. 
    // б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
    //е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)

    public class OneDimArray
    {
        private int[] arrExample;
        public OneDimArray(int arrLenght, int startValue, int step)     //Конструктор с параметрами длины массива, начального значения и шага итерации
        {
            int index = 0;
            arrExample = new int[arrLenght];
            int finishValue = (arrLenght - 1) * step + startValue;  //Нахождение последнего элемента для читаемости кода в цикле

            if (startValue < finishValue)
            {
                for (int i = startValue; i <= finishValue; i += step)
                {
                    arrExample[index] = i;
                    index++;
                }
            }
            else
            {
                for (int i = startValue; i >= finishValue; i += step)
                {
                    arrExample[index] = i;
                    index++;
                }
            }
        }

        //Метод смены знака у всех элементов массива
        public int[] Inverse()
        {
            int[] result = new int[arrExample.Length];
            arrExample.CopyTo(result, 0);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -result[i];
            }

            return result;
        }

        //Метод умножения каждого элемента массива на множитель из параметра
        public int[] Multi(int multiplier)
        {
            for (int i = 0; i < arrExample.Length; i++)
            {
                arrExample[i] = arrExample[i] * multiplier;
            }
            return arrExample;
        }

        //Свойство -четние- получения количества максимальных элементов
        public int MaxCount
        {
            get
            {
                int _maxCount = 1;
                int maxElem = arrExample[0];

                for (int i = 1; i < arrExample.Length; i++)
                {
                    if (arrExample[i] > maxElem) maxElem = arrExample[i];
                    if (maxElem == arrExample[i]) _maxCount++;
                }
                return _maxCount;
            }
        }

        //Свойство -чтение- получения суммы всех элементов массива
        public int Summary
        {
            get
            {
                int sum = 0;
                foreach (int elem in arrExample)
                {
                    sum += elem;
                }
                return sum;
            }
        }

        //Свойство-индексатор для доступа к значениям массива по индексу
        public int this[int i]
        {
            get { return arrExample[i]; }
            set { arrExample[i] = value; }
        }

        //Свойство -чтение- получения созданного массива
        public int[] GetArr { get { return arrExample; } }


    }
    public class _Dictionary
    {
        //Создание конструктора коллекции, необязательные параметры границ выборки случайных чисел
        public static Dictionary<int, int> GetDictionary(int elemCount, int minArrBorder = -100, int maxArrBorder = 100)
        {
            int[] arr = new int[elemCount];
            Dictionary<int, int> simpleDictionary = new Dictionary<int, int>(elemCount);
            Random rand = new Random();
            int i = 0;

            //Небольшой костыль, срабатывания первого Add, т.к. foreach не может проходиться по пустой коллекции
            do
            {
                arr[i] = rand.Next(minArrBorder, maxArrBorder);
                simpleDictionary.Add(arr[i], 1);
                break;
            } while (true);
            i++;

            //Цикл добавления пар ключ-значение в коллекцию из массива
            //с проверкой на наличие в коллекции подобного ключа
            foreach (var key in simpleDictionary.Keys.ToList())     //Перевод коллекции ключей в коллекцию типа List для перебора их в цикле
            {
                while (i < elemCount)
                {
                    arr[i] = rand.Next(minArrBorder, maxArrBorder);

                    if (simpleDictionary.ContainsKey(arr[i]))
                    {
                        simpleDictionary[key]++;        //Инкрементация количества вхождений числа в коллекцию
                    }
                    else
                    {
                        simpleDictionary.Add(arr[i], 1);
                    }
                    i++;
                }
            }
            return simpleDictionary;
        }

        //Метод вычисления частоты вхождения числа
        public static Dictionary<int, double> GetElemFreq(Dictionary<int, int> _dictionary)
        {
            Dictionary<int, double> result = new Dictionary<int, double>(_dictionary.Count);
            double value;

            foreach (var key in _dictionary.Keys.ToList())
            {
                //Конвертация в double каждого операнда выражения, т.к. иначе происходит потеря десятичной части, т.к. один(оба) операнда типа int
                value = Convert.ToDouble(_dictionary[key]) / Convert.ToDouble(_dictionary.Count);
                result.Add(key, value);
            }
            return result;
        }
    }

    #endregion

    #region TASK_4
    //Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
    //Создайте структуру Account, содержащую Login и Password.

    public struct Account
    {
        private string _login;
        private string _password;
        public Account(string login, string password)       //Конструктор структуры с параметрами, нигде не задействован, но пусть будет)
        {
            _login = login;
            _password = password;
        }

        //Метод получения базы данных логинов и паролей из файла
        public static Dictionary<string, string> GetAccountDataBase()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            try
            {
                StreamReader output = new StreamReader("..\\..\\..\\task_4_text_file.txt");
                string[] separators = { " ", ";" };     //Предусмотрено, что логин и пароль разделены не только \n, но и пробелом, и ";"
                string[] database;
                List<string> bufList = new List<string>();  //Буферная коллекция для последующего перемещения ее элементов в словарь
                while (!output.EndOfStream)
                {
                    string bufStr = output.ReadLine();
                    database = bufStr.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);  //Создание массива строк, содержащего
                    foreach (var data in database)                                                      //два элемента, в последующем ключ-значение
                    {
                        bufList.Add(data);
                    }
                    for (int i = 0; i < bufList.Capacity - 3; i++)
                    {
                        result.Add(bufList[i], bufList[i + 1]);     //Добавление пар в словарь
                    }
                    bufList.Clear();    //Очищение буфера, чтобы в каждой итерации цикла он был однозначно пуст
                }
                output.Close();
            }
            catch (FileNotFoundException ex)    //Обработка исключения отсутствия файла в директории
            {
                String.Format($"FILE NOT FOUND\n{ex.Message}");
            }
            return result;
        }

        //Метод проверки вводимого из консоли логина и пароля
        //Принимает в качестве параметра считанный из файла словарь с актуальными/корректными логинами, паролями
        public static void AccountCheck(Dictionary<string, string> DataBase)
        {
            int tryCounter = 3;     //Для ввода будет 3 попытки
            string userLogin;
            string userPassword;
            bool flag;      //Индикатор типа bool для управления циклом и вывода в консоль
            Dictionary<string, string> outputDict = new Dictionary<string, string>();   //Вводимые пользователем данные также поместим в коллекцию

            while (tryCounter != 0)
            {
                Console.Write($"Enter your login: ");
                userLogin = Console.ReadLine();
                Console.Write($"\n Enter your paswword: ");
                userPassword = Console.ReadLine();
                flag = false;                                   //Изначально false, чтобы if на unassigned var не ругался
                outputDict.Add(userLogin, userPassword);

                //Вложенные переборы по коллекциям DataBase == correct login\password
                //и outputDict == пользовательские данные
                foreach (var key in DataBase.Keys.ToList())
                {
                    foreach (var _key in outputDict.Keys.ToList())
                    {
                        if (key == _key && outputDict[_key] == DataBase[key]) flag = true;
                    }
                    if (flag) break; //Если соответствие получено, то сразу завершаем перебор
                }
                outputDict.Clear(); //Перед каждоый итерацией очищаем словарь пользователя, чтобы он хранил только одну пару ключ-значение
                if (flag) { Console.WriteLine($"Welcome!"); break; } //Выводи успех и завершаем цикл запросов
                else if (!flag && tryCounter != 0) 
                    Console.WriteLine($"Uncorrect login/password, please try again.\n Only {tryCounter - 1} tries left."); //Запрос ввода, пока
                else Console.WriteLine($"Acces blocked");  //После 3 попыток неуспех, завершение работы метода             //не закончатся попытки
                tryCounter--;
            }
        }
    }

    #endregion

    #region TASK_5
    //*а) Реализовать библиотеку с классом для работы с двумерным массивом. 
    //    Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, 
    //    сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, 
    //    свойство, возвращающее максимальный элемент массива, 
    //    метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
    //**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    //**в) Обработать возможные исключительные ситуации при работе с файлами.

    public class TwoDimArray
    {
        private static int _stringCount;
        private static int _columnCount;
        private int[,] _array;
        public TwoDimArray(int stringCount, int columnCount)    //Конструктор с размерами массива
        {
            _array = new int[stringCount, columnCount];
            _stringCount = stringCount;
            _columnCount = columnCount;
            Random rand = new Random();
            for (int i = 0; i < _stringCount; i++)
            {
                for (int j = 0; j < _columnCount; j++)
                {
                    _array[i, j] = rand.Next(int.MinValue / 10_000, int.MaxValue / 10_000);
                }
            }
        }

        //Метод подсчета суммы всех элементов
        public int AllSumm()
        {
            int result = 0;
            for (int i = 0; i < _stringCount; i++)
            {
                for (int j = 0; j < _columnCount; j++)
                {
                    result += _array[i, j];
                }
            }
            return result;
        }

        //Метод подсчета суммы тех и только тех элементов, которые больше сравниваемого числа(as parameter)
        public int MoreThanSum(int comparableNum)
        {
            int result = 0;
            for (int i = 0; i < _stringCount; i++)
            {
                for (int j = 0; j < _columnCount; j++)
                {
                    if (_array[i, j] > comparableNum) result += _array[i, j];
                }
            }
            return result;
        }

        //Свойство получения количества строк матрицы
        public int GetStringCount { get { return _stringCount; } }

        //Свойство получения количества столбцов матрицы
        public int GetColCount { get { return _columnCount; } }

        //Свойство получения матрицы
        public int[,] GetArr { get { return _array; } }

        //Свойство-индексатор для обращения к значениям по индексу
        public int this[int i, int j]
        {
            get { return _array[i, j]; }

            set { _array[i, j] = value; }
        }

        //Свойство получения минимального элемента массива
        public int GetArrMin
        {
            get
            {
                int minimal = _array[0, 0];
                for (int i = 1; i < _stringCount; i++)
                {
                    for (int j = 1; j < _columnCount; j++)
                    {
                        if (_array[i, j] < minimal) minimal = _array[i, j];
                    }
                }
                return minimal;
            }
        }

        //Свойство получения максимального элемента массива
        public int GetArrMax
        {
            get
            {
                int maximal = _array[0, 0];
                for (int i = 0; i < _stringCount; i++)
                {
                    for (int j = 0; j < _columnCount; j++)
                    {
                        if (_array[i, j] > maximal) maximal = _array[i, j];
                    }
                }
                return maximal;
            }
        }

        //В рамках данной реализации решил, что будет верным возвращать индекс в виде 1-D массива из 2 элементов
        //индекса строки и столбца соответственно
        public int[] IndexOf(int number)
        {
            int[] result = new int[2];
            for (int i = 0; i < _stringCount; i++)
            {
                for (int j = 0; j < _columnCount; j++)
                {
                    if (_array[i, j] == number)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }
            return result;
        }
    }


    #endregion
}
