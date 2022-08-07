// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
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
int SumOdd (int [] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i+=2)
{
    sum = sum+array[i];
}
return sum;
}
int[] arr_1 = MassNums(11, -5, 10);
Print(arr_1);
Console.WriteLine ($"Сумма нечетных элементов: {SumOdd(arr_1)}");