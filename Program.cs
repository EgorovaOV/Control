// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массива


string[] array = new string[] { "superpuper", "one", "Russia", "+-/*4", "$ %" };

void PrintArray(string[] arr)
{
    int count = arr.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"\"{arr[i]}\" ");
    }
    Console.WriteLine();
}

PrintArray(array);

Console.Write("-> ");

string Diffarray(string[] arr)
{
    string result = String.Empty;

    for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= 3)
        {
            result = result + arr[i];
        }

    }
    return result;
}

string res = Diffarray(array);

Console.Write(res);

//PrintArray (res);не удается преобразовать из "string" в "string[]














