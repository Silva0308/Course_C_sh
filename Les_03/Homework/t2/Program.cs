// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
  return Math.Round(Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2)+Math.Pow(z2 - z1,2)),2);
}


Console.WriteLine ("Введите координату x точки А");
double a =double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату y точки А");
double b =double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату z точки А");
double c =double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату x точки B");
double d =double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату y точки B");
double e =double.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату z точки B");
double f =double.Parse(Console.ReadLine());


Console.WriteLine (Distance(a, b, c, d, e, f));

