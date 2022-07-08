// Расстояние между числами
Console.WriteLine("Write a number: ");
int a =int.Parse(Console.ReadLine());
int i=0;
if ( a==0 )
{
    Console.WriteLine (a);
}
else if ( a>0 )
{
   i=-a;
while(i<=a)
{ 
Console.WriteLine(i); 
i++;
} 
}
else if(a<0)
{
i=-a;
while (i>=a)
{
Console.WriteLine (i);
    i--;
}
}
