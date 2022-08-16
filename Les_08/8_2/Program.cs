// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
string ChangeRowsColumns (int [,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    if (row_size != column_size)
    {
        return "unreal";
    }
    else
    {
        for (int i = 0; i < row_size; i++)
        {
            for (int j = 0; j < i; j++)
            {
                (array[i,j], array[j,i])=(array[j,i], array[i,j]);
            }
        }
        return "real";
    }
}

Console.Write( "Enter the numbers of rows:");
int row = int.Parse(Console.ReadLine());
Console.Write( "Enter the numbers of columns:");
int column = int.Parse(Console.ReadLine());
int [,] arr_1 = MassNum (row, column, 1, 11);
Print (arr_1);
Console.WriteLine(ChangeRowsColumns (arr_1));
Print (arr_1);

