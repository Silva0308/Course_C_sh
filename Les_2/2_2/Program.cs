// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа
//Console.WriteLine("Write a number 10-99:");
//int a = int.Parse(Console.ReadLine());


int MaxDigit (int Number)
{
    if (Number / 10 > Number %10)
    return Number / 10;
    else
    return Number %10;
}
int a = new Random().Next(10,100);
Console.WriteLine(a);
Console.WriteLine(MaxDigit(a));