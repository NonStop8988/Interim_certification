// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Функция - формирование нового массива из строк, длина которых меньше, либо равна 3 символам
string[] FilterStrings(string[] inputArray, int stringLength)
{
    int count = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= stringLength)
        {
            count++;
        }
    }

    string[] filterArray = new string[count];
    int index = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= stringLength)
        {
            filterArray[index] = str;
            index++;
        }
    }
    return filterArray;
}

while(true)
{
    Console.Write("Введите размер массива: ");
    int sizeInputArray = int.Parse(Console.ReadLine()!);
    if (sizeInputArray < 1)
    {
        Console.WriteLine("Введены некорректные данные для размера массива (число меньше 1).");
        continue;
    }
    string[] inputArray = new string[sizeInputArray];
    Console.WriteLine("Введите строки для массива");
    for (int i = 0; i < sizeInputArray; i++)
    {
        Console.Write($"Строка [{i + 1}] массива: ");
        inputArray[i] = Console.ReadLine()!;
    }
    while(true)
    {
        Console.Write("Введите максимально допустимую длину строки: ");
        int stringLength = int.Parse(Console.ReadLine()!);
        if (stringLength < 1)
        {
            Console.WriteLine("Введены некорректные данные для длины строки (число меньше 1)");
            continue;
        }
        string[] filterArray = FilterStrings(inputArray, stringLength);
        Console.WriteLine($"Изначальный массив строк: \t[{string.Join(", ", inputArray)}]");
        if (filterArray.Length == 0)
        {
            Console.WriteLine($"В заданном массиве нет строк, длина которых меньше либо равна '{stringLength}'");
        }
        else
        {
            Console.WriteLine($"Отфильтрованный массив строк: \t[{string.Join(", ", filterArray)}]");
        }
        break;
    }
    break;
}