// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
void Print(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] MassNum(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

int SumNum(int[,] array)
{
    int sum = 0;
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    if (row_size < column_size)
    {
        column_size = row_size;
    }
    else if (row_size > column_size)
    {
        row_size = column_size;
    }
    for (int i = 0; i < row_size; i++)
    {
        sum = sum + array[i, i];
    }

    return sum;

}

Console.Write("Enter the numbers of rows:");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the numbers of columns:");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNum(row, column, 1, 11);
Print(arr_1);
Console.WriteLine(SumNum(arr_1));

