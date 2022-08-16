// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void OrderArrayLines(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);

  for (int i = 0; i < row_size; i++)
  {
    for (int j = 0; j < column_size; j++)
    {
      for (int k = 0; k < column_size - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

Console.Write( "Enter the numbers of rows:");
int row = int.Parse(Console.ReadLine());
Console.Write( "Enter the numbers of columns:");
int column = int.Parse(Console.ReadLine());
int [,] arr_1 = MassNum (row, column, 1, 11);
Print (arr_1);
OrderArrayLines (arr_1);
Print (arr_1);
