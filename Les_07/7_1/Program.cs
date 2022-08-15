﻿// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
//Aₙₙ = m+n. Выведите полученный массив на экран.

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


int [,] MassNum(int row, int column)
{
    int[,] array = new int [row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = i+j;
        } 
    }
    return array;
}

Console.Write( "Enter the numbers of rows:");
int row = int.Parse(Console.ReadLine());
Console.Write( "Enter the numbers of columns:");
int column = int.Parse(Console.ReadLine());
int [,] arr_1 = MassNum (row, column);
Print (arr_1);

