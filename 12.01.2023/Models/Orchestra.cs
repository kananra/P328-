using ConsoleApp6.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models
{
    internal class Orchestra
    {
        public List<Instrument> instruments = new List<Instrument>();

        public Orchestra()
        {
            instruments.Add(new Flute());
            instruments.Add(new Guitar());
            instruments.Add(new Violin());
            instruments.Add(new Piano());

        }
       
        

    }
}
