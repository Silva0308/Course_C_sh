// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.

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
int[] ExpNum(int[] array)
{
    int size = array.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_array = new int[flex_size];
    for (int i = 0; i < size / 2; i++)
    {
        new_array[i] = array[i] * array[size - i - 1];
    }
    if (new_array[flex_size - 1] == 0)
        new_array[flex_size - 1] = array[flex_size - 1];

    return new_array;
}

int[] arr_1 = MassNums(11, -5, 10);
Print(arr_1);
int[] new_arr_1 = ExpNum(arr_1);
Print(new_arr_1);