//Задайте массив из 12 элементов, заполненный случайными 
//числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
int[] Random01Array(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
Console.WriteLine("Введите длину массива");
int a = Convert.ToInt32(Console.ReadLine());
int [] RanArr = Random01Array(a);

void PrintArray(int[] mass)
{
    int count = mass.Length;
    for (int i = 0; i < count; i++)
    {
       Console.Write($"{mass[i]}, "); 
    } 
}
PrintArray(RanArr);
Console.WriteLine (" ");

void SumPosNeg (int [] arr)
{
    int resNeg = 0;
    int resPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<=0)
    {
        resNeg+= arr[i];
    }
        else
    {
        resPos += arr[i];
    }
    }
    Console.WriteLine($"Сумма положительных чисел: {resPos}");
    Console.WriteLine($"Сумма отрицательных чисел: {resNeg}");
}
SumPosNeg (RanArr);