// Напишите программу, которая задаёт массив из 8 элементов случайными числами 
// и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

int[] Random01Array(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(0, 10);
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
       Console.Write(mass[i]); 
    } 
}
PrintArray(RanArr);
