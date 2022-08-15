// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
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

void IndexNum (int [,] array, int row, int column)
{
    Console.WriteLine (array[row,column]);
}
Console.Write( "Enter the numbers of rows:");
int row = int.Parse(Console.ReadLine());
Console.Write( "Enter the numbers of columns:");
int column = int.Parse(Console.ReadLine());
int [,] arr_1 = MassNum (row, column, 1, 11);
Console.Write( "Enter the number of key row:");
int key_row = int.Parse(Console.ReadLine())-1;
Console.Write( "Enter the number of key column:");
int key_column = int.Parse(Console.ReadLine())-1;
Print (arr_1);
IndexNum (arr_1, key_row, key_column);
