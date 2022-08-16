// Напишите программу, которая будет создавать копию 
//заданного массива с помощью поэлементного копирования.
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
int [] CopyMass ( int [] array)
{
    int size = array.Length;
    int [] n_arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        n_arr[i] = array [i];
    }
    return n_arr;
}

int[] arr_1 = MassNums(6, 1, 10);
Print(arr_1);
int [] arr_2 = CopyMass (arr_1);
Print (arr_2);
