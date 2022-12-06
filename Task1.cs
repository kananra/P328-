Console.WriteLine("Zehmet olmasa reqem daxil edin");
int n = Convert.ToInt32(Console.ReadLine());

if (n>0&&n%3==0&&n%7==0) 
{
    Console.WriteLine("Bu eded hem 3 hemde 7e bolunur") ;

}
else
{
    Console.WriteLine("Bu eded hec birine bolunmur");
}