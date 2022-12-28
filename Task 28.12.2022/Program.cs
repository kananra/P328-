using ConsoleApp2.Models;
using ConsoleApp2.Services.Implementations;
using System.Data;

StudentService.Menu();


int num = int.Parse(Console.ReadLine());
StudentService studentservice = new StudentService();

while (num != 0)
{

    switch (num)
    {



        case 1:
            Console.WriteLine("Zehmet olmasa ad,soyad ve ortalamavizi daxil edin");
            studentservice.Create(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
            break;

        case 2:
            Console.WriteLine("Zehmet olmasa silmek istediyiviz Id-ni daxil edin");
            studentservice.Delete(int.Parse(Console.ReadLine()));
            break;

        case 3:
            Console.WriteLine("Zehmet olmasa deyismek istediyiviz Id-ni daxil edin");
            studentservice.Edit(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
            break;

        case 4:
            Student[] Students = studentservice.GetAll();
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
            break;

        case 5:
            studentservice.GetById(int.Parse(Console.ReadLine()));
            break;

    }
    Console.WriteLine("****************************");
    Console.WriteLine("****************************");
    Console.WriteLine("****************************");
    StudentService.Menu();
    num = int.Parse(Console.ReadLine());
    Console.Clear();

}