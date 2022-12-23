using ConsoleApp10;
Console.WriteLine("Please select your car");
Console.WriteLine("1.Bmw");
Console.WriteLine("2.Mercedes");
Console.WriteLine("3.Vaz");
int num = int.Parse(Console.ReadLine());
Bmw Bmw = new Bmw();
Mercedes mercedes = new Mercedes();
Vaz Vaz = new Vaz();

switch (num)
{
    case 1:

        Console.WriteLine("You selected Bmw");
        Bmw.Start();
        Bmw.Drive();
        Bmw.AC();
        break;

    case 2:

        Console.WriteLine("You selected Mercedes");
        mercedes.Start();
        mercedes.Drive();
        mercedes.AC();
        break;

    case 3:
        Console.WriteLine("You selected Vaz");
        Vaz.Start();
        Vaz.Drive();
        break;

    default:
        break;
        
}
