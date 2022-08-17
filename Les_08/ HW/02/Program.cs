// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write("{0,6}",array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int [,] MassNum(int row, int column, int from , int  to)
{
    int[,] array = new int [row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(from,to);
        } 
    }
    return array;
}

int MinSumRow (int [,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    int row_index = 0;
    int row_sum = 0;
    int temp_sum = 0;
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
           temp_sum+=array[i,j];
        }
        for (int j = 1; j < column_size; j++)
        {
            row_sum+=array[i,j];
        }
        if (temp_sum>row_sum)
        {
             temp_sum = row_sum;
             row_index= i+1;
        }
       } 
    return row_index;
}

Console.Write( "Enter the numbers of rows:");
int row = int.Parse(Console.ReadLine());
Console.Write( "Enter the numbers of columns:");
int column = int.Parse(Console.ReadLine());
int [,] arr_1 = MassNum (row, column, 1, 11);
Print (arr_1);
Console.WriteLine($"Index of minimal sum row: {MinSumRow (arr_1)}");

