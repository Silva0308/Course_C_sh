//  Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9
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

int CountArray (int [,] array, int n)
{
    int count = 0;
    foreach (int ar in array)
    {
        if (ar == n)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Enter the numbers of rows:");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the numbers of columns:");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNum(row, column, 1, 11);

Console.Write("Enter a nuьber for counting:");
int n = int.Parse(Console.ReadLine());

Print(arr_1);
Console.WriteLine($"Total {n} in array: {CountArray(arr_1, n)}");