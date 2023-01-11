using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Abstract;

namespace ConsoleApp6.Models
{
    internal class Guitar : Instrument
    {
        public string Color { get; set; } = "Black";
        public Guitar()
        {
            
            Name = "Guitar";
            Model = "Les Paul";
            Price = 2500;
            Brand = "Gibson";
            Material = "Rosewood";

        }
        public override void Sound()
        {
            Console.WriteLine("Guitar sound");
        }
    }
}
