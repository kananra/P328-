using ConsoleApp2;
using System.Data;

StudentService.Menu();


int num = int.Parse(Console.ReadLine());
Group group=new Group();

while(num!=0)
{
    
    switch (num)
    {

        case 0:
            break;

        case 1:
            Console.WriteLine("Zehmet olmasa ad ve soyad daxil edin");
            group.Create(Console.ReadLine(),Console.ReadLine());
              
            Console.WriteLine($"{Group.Count}");
            break;

        case 2:
            Console.WriteLine("Zehmet olmasa silmek istediyiviz Id-ni daxil edin");
            group.Delete(int.Parse(Console.ReadLine()));
            break;

        case 3:
            Console.WriteLine("Zehmet olmasa deyismek istediyiviz Id-ni daxil edin");
            group.Edit(int.Parse(Console.ReadLine()));
            break;

        case 4:
            group.GetAll();
            break;

        case 5:
            group.GetById(int.Parse(Console.ReadLine()));
            break;

    }
    Console.WriteLine("****************************");
    Console.WriteLine("****************************");
    Console.WriteLine("****************************");
    StudentService.Menu();
    num = int.Parse(Console.ReadLine());
    Console.Clear();

}
