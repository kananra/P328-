Console.WriteLine("Zehmet olmasa reqem daxil edin");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 0 && n >= 91&& n <= 100 )
{
    Console.WriteLine("A");
}
else if (n >= 81 && n <= 90)
{
    Console.WriteLine("B");
}
else if (n >= 71 && n <= 80)
{
    Console.WriteLine("C");
}
else if (n >= 61 && n <= 70)
{
    Console.WriteLine("D");
}
else if (n >= 51 && n <= 60)
{
    Console.WriteLine("E");
}
else if (n < 51)
{
    Console.WriteLine("Kesildiniz");
}
else
{
    Console.WriteLine("Reqem duzgun daxil edilmeyib");
}