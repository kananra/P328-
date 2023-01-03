using ConsoleApp3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Services.Interfaces
{
    internal interface IRoomService
    {
        public void Create(int no,double price);
        public Room[] GetAll();
        public void Rezerv(int id);


    }
}
