using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Abstract;

namespace ConsoleApp6.Models
{
    internal class Piano : Instrument
    {

        public string Color { get; set; } = "Black";
        public Piano()
        {
            
            Name = "Piano";
            Model = "BOSTON";
            Price = 3000;
            Brand = "STEINWAY & SONS";
            Material = "Sitka";

        }
        public override void Sound()
        {
            Console.WriteLine("Piano sound");
        }
    }
}
