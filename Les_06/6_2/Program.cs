// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
string Change (int num)
{
    string result = "";
    while (num > 0)
    {
        result = num%2+result;
        num/=2;
    }
    return result;
}

Console.WriteLine("Введите число");
int a =int.Parse(Console.ReadLine());
Console.WriteLine(Change(a));