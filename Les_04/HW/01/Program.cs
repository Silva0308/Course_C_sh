// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int NumExp(int a, int b)
{
int exp = a;
    if (b == 1)
    {
        return exp;
    }
    else
    {
        for (int i = 2; i <= b; i++)
        {
            exp = exp * a;
        }
    }
return exp;
}

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(NumExp(a, b));
