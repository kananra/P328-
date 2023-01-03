using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Hotel
    {
        private static int _id = 0;
        public int Id { get; set; }

        public string Name { get; set; } = "The Lux";
        public Room[] Rooms = new Room[0];

        public Hotel()
        {
            _id++;
            Id= _id;
        }
    }
}
