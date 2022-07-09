internal class NewBaseType
{
    private static void Main(string[] args)
    {
        // Проверка на соотвествие квадрату
        Console.WriteLine("Введите первое число");

        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        int b = int.Parse(Console.ReadLine());
        if (a == b * b)
            Console.WriteLine("Пара верна");

else
            Console.WriteLine("Пара не верна");
    }
}
