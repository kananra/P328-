


using System;
using System.Drawing;

class Student
{
    public string Name;
    public string SurName;
    public string Group;
    public int Point;
    public bool IsGraduated;


    public Student(string name, string surName, string group, int point)
    {

        Name = name;
        SurName = surName;
        Group = group;
        Point = point;
        
    }

   
    public void NameSurname()
    {
        Console.WriteLine($"Name: {Name} Surname: {SurName}");
    }
    public void GetFullInfo()
    {
        Console.WriteLine($"Name: {Name} Name: {SurName} Group: {Group} Point: {Point}");
    }
    public void Graduate()
    {
        if (Point >= 51)
        {

            if (IsGraduated = true)
            {
                Console.WriteLine("You are graduated");
                if (Point > 80)
                {
                    Console.WriteLine("You can enter the test for a second time to increase your point");
                }
                else
                {
                    Console.WriteLine("You can not enter the test for a second time to increase your point");
                }
            }
           
           
        }
        else
        {
            Console.WriteLine("You are failed");
        }
      
}
    
}

