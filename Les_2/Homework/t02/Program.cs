// Напишите программу, 
//которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int SomeNumber = Convert.ToInt32(Console.ReadLine());
string SomeNumberText = Convert.ToString(SomeNumber);
if (SomeNumberText.Length > 2)
{
    Console.WriteLine($"Третья цифра этого числа: {SomeNumberText [2]}");
}
else
{
    Console.WriteLine("Число не имеет третьей цифры");
}