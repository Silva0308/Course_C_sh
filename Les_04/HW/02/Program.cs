// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
int SumNum(int a)
{
    int res = 0;
    while (a > 0)
    {
        res = res + a % 10;
        a = a / 10;
    }
    return res;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine ($"Сумма цифр в числе: {(SumNum(num))}");
