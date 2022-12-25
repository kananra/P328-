using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    internal class Numbers:ICalculate
    {
        public int res;
        public int Num1;
        public int Num2;


        public Numbers( int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public void Divide()
        {
            
            res=Num1/ Num2;
            Console.WriteLine(res);
        }

        public void Difference()
        {
            res=Num1-Num2;
            Console.WriteLine(res);
        }

        public void Multiply()
        {
            res=Num1*Num2; 
        }

        public void Sum()
        {
            res= Num1+Num2;
            Console.WriteLine(res);
        }

        



    }
}
