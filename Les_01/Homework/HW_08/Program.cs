// Четные числа в числе
Console.WriteLine("Введите число: ");
int number =int.Parse(Console.ReadLine());
int i = 2;
while (i<=number)
{
   Console.WriteLine (i);
   i = i+2;
}
if (number <2)
Console.WriteLine ("Четных чисел в составе нет");