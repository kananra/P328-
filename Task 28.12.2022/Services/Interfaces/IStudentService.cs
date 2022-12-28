using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2.Services.Interfaces
{
    internal interface IStudentService
    {

        public void Create(string name, string surname,int avarage);
        public void Delete(int id);
        public void Edit(int id,string name, string surname, int avarage);
        public Student [] GetAll();
        public void GetById(int id);
    }
}
