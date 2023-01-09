
using ConsoleApp4.Enums;
using ConsoleApp4.Models;
using ConsoleApp4.Services.Interfaces;
using System.Text.RegularExpressions;

namespace ConsoleApp4.Services.Implementations
{
    internal class CourseServices : ICourseServices
    {
        public void CreateGroup(string CategoryName, int GroupNo, bool IsOnline)
        {
            if (CategoryName != null && GroupNo != 0)
            {
                bool HasGroup = false;
                foreach (var group in Course.Groupss)
                {
                    if (CategoryName == group.No.Substring(0, 1) && GroupNo.ToString() == group.No.Substring(1))
                    {
                        HasGroup = true;
                        break;
                    }
                }

                if (!HasGroup)
                {
                    Groups Group = new Groups();
                    Group.No = CategoryName + GroupNo;
                    Group.IsOnline = IsOnline;
                    if (IsOnline)
                    {
                        Group.Limit = 15;
                    }
                    else
                    {
                        Group.Limit = 10;
                    }
                    Course.Groupss.Add(Group);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("This group already created");
                    Console.WriteLine("*****************************");
                }
            }
        }

        public void CreateStudent(string Name, string GroupName, bool? IsGuarantee)
        {
            if (Name != null && GroupName != null && IsGuarantee != null)
            {
                bool HasGroup = false;
                if (Course.Groupss.Count != 0)
                {
                    foreach (var group in Course.Groupss)
                    {
                        if (group.No.ToLower() == GroupName.ToLower())
                        {
                            if (group.IsOnline)
                            {
                                if (Course.Students.Count < 15)
                                {
                                    Student student = new Student();
                                    student.FullName = Name;
                                    student.GroupNo = group.No;
                                    student.Type = (bool)IsGuarantee;

                                    Course.Students.Add(student);
                                    group.Students.Add(student);
                                    HasGroup = true;
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("There is no place in group");
                                    Console.WriteLine("This group is full");
                                    return;
                                }
                            }

                            else
                            {
                                if (Course.Students.Count < 10)
                                {
                                    Student student = new Student();

                                    student.FullName = Name;
                                    student.GroupNo = group.No;
                                    student.Type = (bool)IsGuarantee;
                                    Course.Students.Add(student);
                                    group.Students.Add(student);
                                    HasGroup = true;
                                    Console.WriteLine(Course.Students.Count);
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("There is no place in group");
                                    Console.WriteLine("This group is full");
                                    return;
                                }
                            }
                        }
                    }
                }

                if (!HasGroup)
                {
                    Console.Clear();
                    Console.WriteLine($"{GroupName} not found");
                    Console.WriteLine("Please create Group");
                    Console.WriteLine("**********************************");
                }
            }
            Console.Clear();
        }

        public void EditGroup(string GroupName)
        {
            if (Course.Groupss.Count != 0)
            {
                foreach (var group in Course.Groupss)
                {
                    if (group.No.ToLower().Trim() == GroupName.ToLower().Trim())
                    {
                        Console.WriteLine("Please write new group number");
                        int NewGroupNo;
                    CheckIsNumberGroupNo:
                        bool IsNumber = int.TryParse(Console.ReadLine(), out NewGroupNo);
                        if (!IsNumber)
                        {
                            Console.WriteLine("Please write number");
                            goto CheckIsNumberGroupNo;
                        }
                        foreach (var qrup in Course.Groupss)
                        {
                            if ((group.No.Substring(0, 1) + NewGroupNo.ToString()).ToLower() == qrup.No.ToString().ToLower())
                            {
                                Console.Clear();
                                Console.WriteLine("This group is already avaliable ");
                                return;
                            }
                        }
                        Console.Clear();
                        group.No = group.No.Substring(0, 1) + NewGroupNo.ToString();
                        Console.WriteLine("Successfully Replaced");
                        return;
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please create group");
                return;
            }
            Console.Clear();
            Console.WriteLine("Please write correctly");
        }



        public void ShowAllStudents()
        {
            if (Course.Groupss.Count > 0)
            {
                foreach (var group in Course.Groupss)
                {
                    if (Course.Students.Count > 0)
                    {
                        if (group.Students.Count > 0)
                        {
                            foreach (var student in group.Students)
                            {
                                Console.WriteLine($"Fullname--{student.FullName},Group No--{student.GroupNo},Status--{group.IsOnline}");
                            }
                        }
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Students not found");
                        return;
                    }
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Please create group");
                return;
            }

        }

        public void ShowGroups()
        {
            if (Course.Groupss.Count != 0)
            {
                Console.Clear();
                foreach (var group in Course.Groupss)
                {
                    string GroupType = "";
                    if (group.IsOnline)
                    {
                        GroupType = "Online";
                    }
                    else
                    {
                        GroupType = "Offline";

                    }
                    Console.WriteLine($"Group No : {group.No} , Group Type : {GroupType} ,Students counts : {group.Students.Count}");
                    Console.WriteLine("***************************************");
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("There is not group");
                Console.WriteLine("****************************");
                return;
            }
        }

        public void ShowStudentsInGroup(string GroupName)
        {
            if (Course.Groupss.Count != 0)
            {

                foreach (var group in Course.Groupss)
                {
                    if (group.No.Trim().ToLower() == GroupName.Trim().ToLower())
                    {
                        if (group.Students.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("This group is empty");
                            return;
                        }

                        foreach (var student in group.Students)
                        {
                            string studentStatus = "";
                            if (student.Type)
                            {
                                studentStatus = "Guarantee";
                            }
                            else
                            {
                                studentStatus = "Without Guarantee";
                            }
                            Console.WriteLine($"Fullname of student : {student.FullName} , Student Status: {studentStatus}");
                            Console.WriteLine("*************************");
                        }
                        continue;
                    }
                    else if (Course.Groupss.Count == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Group not found");
                        return;
                    }

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please create group");
                return;
            }
        }
    }


}




