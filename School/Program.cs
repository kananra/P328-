Console.WriteLine("Please enter your Name,Surname,Group,Point");
Student student = new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
student.NameSurname();
student.GetFullInfo();
student.Graduate();
