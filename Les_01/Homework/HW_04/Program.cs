//  Сравнение трех чисел
Console.WriteLine("Введите первое число:");
int num_1 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_2 =int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num_3 =int.Parse(Console.ReadLine());
int max = 0;
if (num_1>num_2)
{
    max =num_1;
}
else 
{
    max =num_2;
}
if (max< num_3)
{
    max = num_3;
}
Console.WriteLine ("Наибольшее число:");
Console.WriteLine (max);