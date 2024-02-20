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

