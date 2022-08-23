// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.
void ValueSetMinMax(int min, int max)
{
    if (max%2 == 0)
    {
        if (max<min) return;
    ValueSetMinMax(min,max-2);
    Console.Write($"{max}, ");
    }
    else
    {
        if (max-1<min) return;
    ValueSetMinMax(min,max-2);
    Console.Write($"{max-1}, ");
    }
    
}

ValueSetMinMax(3,9);