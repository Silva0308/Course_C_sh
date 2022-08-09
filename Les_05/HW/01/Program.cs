// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве

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
void OddEven(int[] array)
{
    int countOdd = 0;
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            countEven++;
        else
            countOdd++;
    }
    Console.WriteLine($"Количество четных чисел: {countEven}");
    Console.WriteLine($"Количество нечетных чисел: {countOdd}");

}
int[] arr_1 = MassNums(9, 100, 1000);
Print(arr_1);
OddEven(arr_1);