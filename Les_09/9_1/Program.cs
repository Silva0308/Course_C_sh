// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void Numbers(int num)
{
 if (num == 0) return;
 Numbers (num-1);
 Console.Write($"{num}, ");
}

Console.WriteLine ("Please write n");
int n = int.Parse(Console.ReadLine()); 
Numbers (n);