using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal abstract class Person:ICalculate
    {
        public string Name { get; set; }
        public string SurName { get; set; }

       

        public void GetFullName() 
        {

            Console.WriteLine("Kanan Rahimov");
        
        }

        public abstract void Method();
        public virtual void Sum()
        {
            Console.WriteLine(15+20);
        }

        public void Multiply()
        {
            Console.WriteLine(5*6);
        }

        public void Divide()
        {
            Console.WriteLine(10/5);
        }


    }

    

    
}
    
