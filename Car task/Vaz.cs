using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Vaz: Auto, ICars
    
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting");
        }

        public void Drive()
        {
            Console.WriteLine("1-e kecdiz");
        }
       
    }
}
