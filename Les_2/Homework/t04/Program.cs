//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 6)
{
    Console.WriteLine("Это будний день");
}
else if (day == 6)
{
    Console.WriteLine("Ура! Выходные!");
}
else if (day == 7)
{
    Console.WriteLine("Выходной, но завтра на работу");
}
else
{
    Console.WriteLine("Ошибка, такого дня в неделе нет");
}