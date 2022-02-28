Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
while (a < n) 
{
    int b = n - a;
    if (b > 1) 
    {
    a = a + 2;
    Console.Write(a + ", ");
    }
}