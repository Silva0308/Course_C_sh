// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

int SumNum(int a)
{
    if (a == 0) return 0;
    return SumNum(a / 10) + a % 10;
}

Console.WriteLine(SumNum(123));