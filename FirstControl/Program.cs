// Написать программу, которая из имеющегося массива строкформирует массив из строк,
// длинна которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// Использовать исключительно массивы.

string[] InputArray()
{
    string[] arrayString = Console.ReadLine().Split(' ', ',');
    return arrayString;
}

bool CheckInput(string[] array)
{
    if (array.Length - 1 == 0)
    {
        Console.WriteLine("Input error!");
        return false;
    }
    return true;
}

void ArraySort(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int legth = array[i].Length;
        if (legth > 3)
            array[i] = string.Empty;
    }
}





// Console.Clear();
string[] array = InputArray();



