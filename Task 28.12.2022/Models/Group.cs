using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Services.Interfaces;

namespace ConsoleApp2.Models
{
    internal class Group
    {

        private static int _Id = 0;
        public readonly int Id;


        public string Name { get; set; }

        public string SurName { get; set; }

        public Student[] Students = new Student[0];

        public Group()
        {
            _Id++;
            Id = _Id;

        }
       


    }
}
