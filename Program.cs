// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
}

string[] GetStringsOfLength(int maxStringLength, string[] array)
{
    string[] resultArray = new string[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxStringLength)
        {
            string[] tempArray = new string[resultArray.Length + 1];
            resultArray.CopyTo(tempArray, 0);
            tempArray[tempArray.Length - 1] = array[i];
            resultArray = tempArray;
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    System.Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}

System.Console.WriteLine("Введите количество элементов массива строк: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];

System.Console.WriteLine("Убрать из массива строки, длина которых более: ");
int maxLength = Convert.ToInt32(Console.ReadLine());

FillArray(array);
PrintArray(GetStringsOfLength(maxLength, array));
