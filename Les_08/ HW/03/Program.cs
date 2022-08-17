// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Print(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write("{0,6}", array[i, j]);
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
int[,] ArrayMult(int[,] array1, int[,] array2)
{

    int row_size1 = array1.GetLength(0);
    int column_size1 = array1.GetLength(1);
    int row_size2 = array2.GetLength(0);
    int column_size2 = array2.GetLength(1);
    int[,] mult = new int[row_size1, column_size2];
    if (column_size1 != row_size2)
    {
        Console.WriteLine("impossilbe");
    }
    else
    {
        for (int i = 0; i < row_size1; i++)
        {
            for (int j = 0; j < column_size2; j++)
            {

                int sum = 0;
                for (int k = 0; k < column_size1; k++)
                {
                    sum += array1[i, k] * array2[k, j];
                }
                mult[i, j] = sum;
            }
        }
    }
    return mult;
}

Console.Write("Enter the numbers of rows:");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the numbers of columns:");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNum(row, column, 1, 11);
Print(arr_1);
Console.Write("Enter the numbers of rows:");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Enter the numbers of columns:");
int column1 = int.Parse(Console.ReadLine());
int[,] arr_2 = MassNum(row1, column1, 1, 11);
Print(arr_2);

int [,]result = ArrayMult(arr_1, arr_2);
Print (result);