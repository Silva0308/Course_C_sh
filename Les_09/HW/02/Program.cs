//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumMinMax(int min, int max)
{
    if (max<min) return 0;
    return SumMinMax(min,max-1)+max;
}

int n = SumMinMax(1,7);
Console.WriteLine (n);