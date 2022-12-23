using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal interface ICars
    {
        public void Drive();
        public virtual void AC()
        {
            Console.WriteLine("Kondiseneri qosdunuz");
        }
    }
}
