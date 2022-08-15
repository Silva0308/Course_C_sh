// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, 
// и замените эти элементы на их квадраты.

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

int [,] ArraySq( int  [,] array )
{
 int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 1; i < row_size; i+=2)
    {
        for (int j = 1; j < column_size; j+=2)
        {
             array[i, j] *=array [i,j];
        }
    }
    return array;
}
Console.Write( "Enter the numbers of rows:");
int row = int.Parse(Console.ReadLine());
Console.Write( "Enter the numbers of columns:");
int column = int.Parse(Console.ReadLine());
int [,] arr_1 = MassNum (row, column, 1, 11);
Print (arr_1);
int [,] arr_2 = ArraySq (arr_1);
Print (arr_2);

