// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
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

void ArithmeticMean(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);


    for (int j = 0; j < column_size; j++)
    {
        double arithmeticMean = 0;
        for (int i = 0; i < row_size; i++)
        {
            arithmeticMean += array[i, j];
        }
        arithmeticMean = Math.Round(arithmeticMean / row_size, 1);
        Console.WriteLine($"Arithmetic Mean  № {j + 1} = {arithmeticMean}");
    }


}
// for (int j = 0; j < column_size; j++) 
Console.Write("Enter the numbers of rows:");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the numbers of columns:");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNum(row, column, 1, 11);
Print(arr_1);
ArithmeticMean (arr_1);

