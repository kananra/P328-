using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface IStudentService
    {
      
        public string [] Create(string name,string surname);
        public void Delete(int id);
        public void Edit(int id);
        public void GetAll();
        public void GetById(int id);
    }
}
