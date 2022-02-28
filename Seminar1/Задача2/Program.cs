Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < c)
    if (b < c)
{
    Console.Write("max ");
    Console.WriteLine(c);
}
if (a < b)
    if (b > c)
{
    Console.Write("max ");
    Console.WriteLine(b);   
}
if (a > b)
    if (a > c)
{    
    Console.Write("max ");
    Console.WriteLine(a); 
}      
