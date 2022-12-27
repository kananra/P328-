using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Group :IStudentService
    {

        public static int Count;
        public int Id;


        public string Name { get; set; }

        public string SurName { get; set; }

        public string[] Students = { };

        public Group()
        {
            Id = Count;
           
        }
        public string[] Create(string name, string surname)
        {
            if (name.Length >= 3 && name.Length <= 15 && surname.Length >= 3 && surname.Length <= 15)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = name + " " + surname;
                Count++;

            }
            else
            {
                Console.WriteLine("Ad ve soyad 3 herfden kicik ve 15 herfden boyuk olmamalidir");
            }

            return Students;
        }

        public void Delete(int id)
        {
            if (id <=Students.Length)
            {
                Students[id - 1] = "";
                
                
            }
            else
            {
                Console.WriteLine("Bu ID-de telebe yoxdur");
            }
            
        }

        public void Edit(int id)
        {
            if (id <=Students.Length)
            {
                Console.WriteLine("Zehmet olmasa evez edecek ad ve soyadi daxil edin");
                string name = Console.ReadLine();
                string surname = Console.ReadLine();


                if (name.Length >= 3 && name.Length <= 15 && surname.Length >= 3 && surname.Length <= 15)
                {
                    Students[id-1]=name + " " + surname;
                }
                else
                {
                    Console.WriteLine("Ad ve soyad 3 herfden kicik ve 15 herfden boyuk olmamalidir");
                }

            }
            else
            {
                Console.WriteLine("Bu Id-de telebe yoxdur");
            }
        }

        public void GetAll()
        {
            foreach (string i in Students)
            {
                Console.WriteLine(i);
            }
        }

        public void GetById(int id)
        {
            if (id <=Students.Length)
            {
                Console.WriteLine(Students[id-1]);

            }
            else
            {
                Console.WriteLine("Bu Id-de telebe yoxdur");
            }
        }


    }
}
