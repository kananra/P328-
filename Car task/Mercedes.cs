using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Mercedes: Auto, ICars
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting");
        }

        public void Drive()
        {
            Console.WriteLine("D-e kecdiz");
        }
        public void AC()
        {
            Console.WriteLine("Kondiseneri qosdunuz");
        }
    }
}
