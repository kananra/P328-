using ConsoleApp4.Enums;
using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Services.Interfaces
{
    internal interface ICourseServices
    {
        public void CreateGroup(string CategoryName, int GroupNo, bool IsOnline);
        public void CreateStudent(string Name, string GroupName, bool? IsGuarantee);
        public void EditGroup(string GroupName);
        public void ShowAllStudents();
        public void ShowGroups();
        public void ShowStudentsInGroup(string GroupName);



    }
}
