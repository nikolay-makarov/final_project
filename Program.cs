/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/
string[] GetData(string message)
{
    Console.Write($"{message}: ");
    return Console.ReadLine()!.Split();
}

void PrintArray(string[] array)
{
    Console.Write('[');
    Console.Write(string.Join(", ", array));
    Console.Write("]\n");
}

string[] MakeResultArray(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            counter += 1;
    }
    string[] resultArray = new string[counter];
    counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[counter] = array[i];
            counter += 1;
        }
    }
    return resultArray;
}

string[] array = GetData("Введите элементы массива, разделенные пробелом");
Console.Write("Введенный Вами массив: ");
PrintArray(array);
string[] result = MakeResultArray(array);
Console.Write("Массив из строк, длинна которых <= 3: ");
PrintArray(result);
