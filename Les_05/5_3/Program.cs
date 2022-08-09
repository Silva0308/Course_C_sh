// Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int Count(int[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
        if (10 <= array1[i] && array1[i] <= 99)
        {
            count++;
        }
    return count;
}

int[] arr_1 = MassNums(12,-5, 123);
Print(arr_1);
Count (arr_1);
Console.WriteLine($"Количестов элементов в заданном диапазоне: {Count(arr_1)}");