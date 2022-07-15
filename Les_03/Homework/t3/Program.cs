// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
void Square ( int N) 
{
    int index = 1;
    while (index <= N)
    {
        Console.WriteLine (Math.Pow(index,3));
        index ++;
    }
}
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
Square (N);



