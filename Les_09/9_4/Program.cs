﻿// Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.

int MultNum(int a, int b)
{
    if (b==0) return 1;
    return MultNum(a, b-1)*a;
}

Console.WriteLine(MultNum(2,4));