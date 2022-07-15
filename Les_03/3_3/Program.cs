// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
void Square ( int N) 
{
    int index = 1;
    while (index <= N)
    {
        Console.WriteLine (Math.Pow(index,2));
        index ++;
    }
}
Square (5);