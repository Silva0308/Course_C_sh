// Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру это числа

int SomeNumber = new Random().Next(100,1000);
Console.WriteLine(SomeNumber);
int a = SomeNumber/100;
int c = SomeNumber%10;
Console.Write (a);
Console.WriteLine (c);