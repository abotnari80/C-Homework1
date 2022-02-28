Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.Write("max ");
    Console.WriteLine(b);
    Console.Write("min ");
    Console.WriteLine(a);
}

else
{
    Console.Write("max ");
    Console.WriteLine(a);
    Console.Write("min ");
    Console.WriteLine(b);
}

