using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Abstract
{
    internal abstract class Instrument
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }


        public abstract void Sound();


    }
}
