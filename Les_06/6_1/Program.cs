// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
void Triangle (int x, int y, int z)
{
    if ((x+y)> z && (x+z) > y && (y+z) >x)
    {
        Console.WriteLine ("Существует");
    }
    else
    {
        Console.WriteLine ("Не существует");
    }
}

Console.WriteLine("Введите первое число");
int a =int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b =int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c =int.Parse(Console.ReadLine());
Triangle (a,b,c);
