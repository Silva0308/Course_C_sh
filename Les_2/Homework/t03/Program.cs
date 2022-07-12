// Напишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру это числа

int SomeNumber = new Random().Next(100,1000);
Console.WriteLine(SomeNumber);
string number = SomeNumber.ToString();
Console.Write(number[0]);
Console.WriteLine(number[2]);


