using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Abstract;

namespace ConsoleApp6.Models
{
    internal class Violin : Instrument
    {

        public string Color { get; set; } = "Brown";
        public Violin()
        {

            
            Name = "Violin";
            Model = "Amati";
            Price = 1500;
            Brand = "Stentor";
            Material = "Tonewoods";
        }
        public override void Sound()
        {
            Console.WriteLine("Violin sound");
        }
    }
}
