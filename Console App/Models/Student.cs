using ConsoleApp4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Student
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public bool Type { get; set; }

        public Student()
        {
            Id = _id;
            _id++;
        }
    }
        
}
