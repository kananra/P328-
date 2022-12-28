using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Student
    {
        private static int _Id = 0;
        public readonly int Id;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Avarage { get; set; }
       
        public Student()
        {
            _Id++;
            Id = _Id;
        }

        public override string ToString()
        {
            return $"{Name} {SurName} {Avarage}";
        }
    }



}
