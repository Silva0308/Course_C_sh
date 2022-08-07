// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size, double from, double to)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(from + rand.NextDouble() * (to - from), 2);
    }
    return arr;
}

void MinMax(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
    }
    Console.WriteLine("min = {0}", min);

    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
    }
    Console.WriteLine("max = {0}", max);
    Console.WriteLine($"Разница между максимальным и минимальным значением массива = {max - min}");
}
double[] arr_1 = MassNums(8, -10, 10);
Print(arr_1);
MinMax(arr_1);