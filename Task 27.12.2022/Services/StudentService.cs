using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal static class StudentService
    {
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
