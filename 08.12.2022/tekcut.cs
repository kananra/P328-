Console.WriteLine("Zehmet olmasa reqem daxil edin");
int n = Convert.ToInt32(Console.ReadLine());
if (n%2==0)
{
    n = n / 2;
    Console.WriteLine(n);
}
else
{
    n = n * 2;
    Console.WriteLine(n);
}