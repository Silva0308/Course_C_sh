// // 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно
Console.WriteLine ("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int numberB = int.Parse(Console.ReadLine());
void Method1 (int a, int b)
{
    if (a%b == 0)
    Console.WriteLine ("кратно");
    else
    {
        Console.WriteLine ($"не кратно {b}");
    }
}

Method1 (numberA,numberB);