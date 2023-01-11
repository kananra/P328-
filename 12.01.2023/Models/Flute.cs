using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Abstract;

namespace ConsoleApp6.Models
{
    internal class Flute : Instrument
    {
        public string Color { get; set; } = "Silver";
        public Flute()
        {
            
            Name = "Flute";
            Model = "YFL-221";
            Price = 425;
            Brand = "Yamaha";
            Material = "Nickel";
        }

        public override void Sound()
        {
            Console.WriteLine("Flute sound");
        }
    }
}
