using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal static class Course
    {
        public static List<Groups> Groupss { get; set; }
        public static List<Student> Students { get; set; }
        static Course()
        {
            Groupss = new List<Groups>();
            Students = new List<Student>();
        }


    }
}
