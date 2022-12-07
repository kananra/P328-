Console.WriteLine("Zehmet olmasa yasinizi daxil edin");
int age =Convert.ToInt32(Console.ReadLine());
int n=18;
if (age>=18)
{
    Console.WriteLine("Suruculuk vesiqesi ala bilersiniz");
}
else
{
    n = n - age;
    Console.WriteLine(n +"iliniz qalib suruculuk vesiqesi almaga");
}