//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
string[] Input()
{
    Console.WriteLine("Инициализация массива строк");
    A:
    Console.Write("Введите количество элементов массива (положительное целое число):\t");
    string str = Console.ReadLine();
    if (int.TryParse(str, out int n) == false || n <= 0)
    {
        Console.WriteLine("Введите пожалуйста корректные данные (положительное целое число)");
        Console.WriteLine("Для продолжения нажмите клавишу Enter");
        Console.WriteLine("Для выхода из программы нажмите клавишу Escape");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            goto A;
        }
        else if (Console.ReadKey().Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
        else
        {
            Environment.Exit(0);
        }
    }
    string[] array = new string[n];
    Console.WriteLine("Введите слова для заполнеия массива строк");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} слово:\t");
        string s = Console.ReadLine();
        if (s == "" || s == " ")
        {
            array[i] = "Пустая строка";
        }
        else
        {
            array[i] = s;
        }
    }
    Console.WriteLine();
    return array;
}
void PrintArray(string[] arr, string s)
{
    Console.WriteLine(s);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
string[] NewArray(string[] arr, int sim)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= sim)
        {
            count++;
        }
    }
    if (count == 0)
    {
        string[] arr0 = new string[] { };
        return arr0;
    }
    else
    {
        string[] arr1 = new string[count];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= sim)
            {
                arr1[j] = arr[i];
                j++;
            }
        }
        return arr1;
    }
}
void Task()
{
    int simbols = 3;
    string[] array = Input();
    string s = "Создан массив строк и введены следующие элементы:";
    PrintArray(array, s);
    Console.WriteLine();
    string[] result = NewArray(array, simbols);
    Console.WriteLine();
    string s1 =
        "Сформирован новый массив из строк, длина которых меньше, либо равна трем символам:";
    if (result.Length == 0)
    {
        Console.WriteLine("Заданный массив строк не содержит элементов, длина которых меньше, либо равна трем символам");
    }
    else
    {
        PrintArray(result, s1);
    }
}
Task();