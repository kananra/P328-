using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3.Models
{
    internal class Room
    {
        private static int _id = 0;
        public int Id { get; set; }
        private static int _No;
        public int No;

        public double Price { get; set; }

        public bool IsRezerved { get; set; }


        public Room()
        {
            _id++;
            Id = _id;
        }

        public static int GetNo(int data)
        {
            while (_No == data)
            {

                Console.WriteLine("Bu otaq artiq movcuddur");
                data = int.Parse(Console.ReadLine());


            }

            return _No = data;
        }
        public override string ToString()
        {
            return $"{No} {Price}";
        }
    }
}
