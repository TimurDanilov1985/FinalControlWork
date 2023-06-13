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
    Console.Write("Введите количество элементов массива (положительное целое число):\t");
    string str = Console.ReadLine();
    int n = Convert.ToInt32(str);
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
void Task()
{
    string[] array = Input();
    string s = "Создан массив строк и введены следующие элементы:";
    PrintArray(array, s);
}
Task();