using ConsoleApp4.Enums;
using ConsoleApp4.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Services.Implementations
{
    internal static class Menuservice
    {
        private static CourseServices courseservice = new CourseServices();
        public static void CreateGroupMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose category");
            Console.WriteLine("   ");

        CheckCategoryNo:
            CategoryMenu();
        NotFoundError:
            int CategoryNo;
            bool IsCategoryNo = int.TryParse(Console.ReadLine(), out CategoryNo);
            int EnumMin = Enum.GetValues(typeof(GroupCategory)).Cast<int>().Min();
            int EnumMax = Enum.GetValues(typeof(GroupCategory)).Cast<int>().Max();

            if ((CategoryNo < EnumMin || CategoryNo > EnumMax))
            {
                Console.Clear();
                Console.WriteLine("Category is not found");
                Console.WriteLine("Please enter valid number");
                Console.WriteLine("");
                CategoryMenu();

                goto NotFoundError;
            }
            else
            {
                if (!IsCategoryNo)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the number");
                    Console.WriteLine("  ");
                    goto CheckCategoryNo;
                }
                else if (CategoryNo == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the  group number great than 0");
                    Console.WriteLine("");
                    goto CheckCategoryNo;
                }

                string CategoryName = "";

                foreach (GroupCategory category in Enum.GetValues(typeof(GroupCategory)))
                {
                    if (CategoryNo == (int)category)
                    {
                        CategoryName = category.ToString().Substring(0, 1);
                    }
                }


                Console.WriteLine("Please enter the group number");
                int GroupNo;
            CheckGroupNo:
                bool isNumber = int.TryParse(Console.ReadLine(), out GroupNo);
                if (!isNumber)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the number");
                    goto CheckGroupNo;
                }
                else if (GroupNo == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the number great than 0");
                    Console.WriteLine("");
                    goto CheckGroupNo;
                }

                bool IsOnline;
                int IntCreateGroup;
                Console.Clear();
                Console.WriteLine($"Online or offline group do you want create?");
                CheckIsOnline:
                Console.WriteLine($"~~~For online Press 0");
                Console.WriteLine($"~~~For offline Press 1");
                bool CreateCheckStatus = int.TryParse(Console.ReadLine(), out IntCreateGroup);
                if (CreateCheckStatus)
                {
                    if (IntCreateGroup == 1)
                    {
                        IsOnline = false;
                    }
                    else if (IntCreateGroup == 0)
                    {
                        IsOnline = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter 0 or 1");
                        Console.WriteLine("");
                        goto CheckIsOnline;
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the number");
                    goto CheckIsOnline;
                }
                courseservice.CreateGroup(CategoryName, GroupNo, IsOnline);
                Console.Clear();
                return;
            }

        }


        public static void CreateStudentMenu()
        {
            Console.Clear();
            string FullName = "";
            namecheck:
            fullcheck:
            Console.WriteLine("Please write your Name ");
            string Name = Console.ReadLine();
            Console.WriteLine("Please write your Surname ");
            string Surname = Console.ReadLine();
            while (true)
            {
                bool namestatus = int.TryParse(Name, out int namecheck);
                bool surnamestatus = int.TryParse(Surname, out int surnamecheck);
                if (namestatus && surnamestatus)
                {
                    Console.WriteLine(" Please don`t write number ");
                    goto namecheck;
                }
                else if (Name.Length >= 3 && Name.Length <= 15 && Surname.Length <= 15 && Surname.Length >= 3)
                {
                    Name.Trim();
                    Console.WriteLine("");
                    Surname.Trim();
                    Console.WriteLine("");
                    FullName = Name + " " + Surname;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The letters of your fullname cannot be less than 3 and more than 15");
                    goto fullcheck;
                }
            }

            Console.WriteLine("Write your group number");
            string groupName = Console.ReadLine();
            Console.WriteLine($"Do you have a guaranteed education?");
            bool isGuarantee;
            int IntCreateStudent;
            CheckIsNumberIsGuarantee:
            Console.WriteLine($"For guaranteed press 1 ");
            Console.WriteLine($"For without guaranteed press 0");
            bool CreateStudentStatus = int.TryParse(Console.ReadLine(), out IntCreateStudent);
            if (CreateStudentStatus)
            {
                if (IntCreateStudent == 0)
                {
                    isGuarantee = false;
                }
                else if (IntCreateStudent == 1)
                {
                    isGuarantee = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please write 1 or 0");
                    Console.WriteLine("***********************");
                    goto CheckIsNumberIsGuarantee;
                }
            }

            else
            {
                Console.WriteLine("Please write number");
                goto CheckIsNumberIsGuarantee;
            }

            courseservice.CreateStudent(FullName, groupName, isGuarantee);

        }

        public static void ShowAllStudentsMenu()
        {
            courseservice.ShowAllStudents();
        }
        public static void ShowAllGroupsMenu()
        {
            courseservice.ShowGroups();
        }

        public static void ShowStudentsInGroupMenu()
        {

            Console.WriteLine("Please write group name");
        namecheckempty:
            string groupName = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(groupName))
            {
                Console.Clear();
                Console.WriteLine("Cannot be empty");
                Console.WriteLine("Please enter Group name");
                Console.WriteLine("  ");
                goto namecheckempty;
            }
            courseservice.ShowStudentsInGroup(groupName);
        }

        public static void ShowEditGroupMenu()
        {
            Console.WriteLine("Please write group name");
        editgroup:
            string groupName = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(groupName))
            {
                Console.Clear();
                Console.WriteLine("Cannot be empty,write again please");
                Console.WriteLine("  ");
                goto editgroup;
            }
            courseservice.EditGroup(groupName);

        }
        public static void Menu()
        {
            Console.WriteLine("Choose one of them ");
            Console.WriteLine("   ");
            Console.WriteLine("1.Create new group");
            Console.WriteLine("*******************");
            Console.WriteLine("2.Show all groups");
            Console.WriteLine("*******************");
            Console.WriteLine("3.Edit group");
            Console.WriteLine("*******************");
            Console.WriteLine("4.Show students in group");
            Console.WriteLine("*******************");
            Console.WriteLine("5.Show all students");
            Console.WriteLine("*******************");
            Console.WriteLine("6.Create new student");
            Console.WriteLine("*******************");

        }
        public static int MenuInput()
        {
            bool status = true;
            while (status)
            {
                status = int.TryParse(Console.ReadLine(), out int result);

                if (result > 0 && result < 7 && status == true)
                {
                    status = false;
                    return result;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter correctly");
                    break;
                }
            }
            return 0;

        }
        static void CategoryMenu()
        {

            foreach (GroupCategory category in Enum.GetValues(typeof(GroupCategory)))
            {
                Console.WriteLine($" For {category} press {(int)category}");
                Console.WriteLine("*******************");
            }
        }
    }
}
