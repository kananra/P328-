using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student
    {
       
        private int _Avarage;
        public int Avarage
        {
            get => _Avarage;
            set
            {
                if (value>=0&&value<=100)
                {
                    _Avarage = value;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa reqemi duzgun daxil edin");
                }

            }
        }

    }



}
