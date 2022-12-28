using ConsoleApp2.Models;
using ConsoleApp2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services.Implementations
{
    internal class StudentService : IStudentService
    {
        Group group=new Group();
        public void Create(string name, string surname, int avarage)
        {
            if (name.Length>=3&&name.Length<=15&&surname.Length>=3&&surname.Length<=15&&avarage>=0&&avarage<=100)
            {
                Student student = new Student
                {

                    Name = name,
                    SurName = surname,
                    Avarage = avarage
                };
                Array.Resize(ref group.Students, group.Students.Length + 1);
                group.Students[group.Students.Length - 1] = student;

            }
            else
            {
                Console.WriteLine("Ad,soyad ve ya ortalamavizi duzgun daxil edin");
            }
            

        }

        public void Delete(int id)
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id==id)
                {
                    group.Students[i] = group.Students[group.Students.Length - 1];
                    Array.Resize(ref group.Students,group.Students.Length - 1);
                    return;
                }

            }
            Console.WriteLine("Bu id-de telebe yoxdur");
        }

        public void Edit(int id, string name, string surname, int avarage)
        {
            for(int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id == id)
                {
                    if (name.Length >= 3 && name.Length <= 15 && surname.Length >= 3 && surname.Length <= 15 && avarage >= 0 && avarage <= 100)
                    {
                        group.Students[i].Name = name;
                        group.Students[i].SurName = surname;
                        group.Students[i].Avarage = avarage;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Ad,soyad ve ya ortalamavizi duzgun daxil edin");
                        return;
                    }
                    
                }

            }
            Console.WriteLine("Bu id-de telebe yoxdur");
        }

        public Student[] GetAll()
        {
            return group.Students;
        }

        public void GetById(int id)
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id == id)
                {
                    Console.WriteLine(group.Students[i]);
                    return;
                }

            }
            Console.WriteLine("Bu id-de telebe yoxdur");
            



        }
        public static void Menu()
        {
            Console.WriteLine("1.Create");
            Console.WriteLine("2.Delete");
            Console.WriteLine("3.Edit");
            Console.WriteLine("4.All Students");
            Console.WriteLine("5.Find Student");
            Console.WriteLine("0.Exit");
        }
    }
}
