using ConsoleApp4.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Groups
    {
        static int _id = 1;
        public int Id { get; set; }
        public string No { get; set; }
        public bool IsOnline { get; set; }
        public int Limit { get; set; }
        public List<Student> Students { get; set; }
        public Groups()
        {
            Id = _id;
            _id++;
            Students = new List<Student>();
        }

    }
}
