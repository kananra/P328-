using ConsoleApp4.Services.Implementations;

Console.ForegroundColor = ConsoleColor.Green;


do
{
    Menuservice.Menu();


    switch (Menuservice.MenuInput())
    {
        case 1:
            Menuservice.CreateGroupMenu();

            break;
        case 2:
            Menuservice.ShowAllGroupsMenu();
            break;
        case 3:
            Menuservice.ShowEditGroupMenu();
            break;
        case 4:
            Menuservice.ShowStudentsInGroupMenu();
            break;
        case 5:
            Menuservice.ShowAllStudentsMenu();
            break;

        case 6:
            Menuservice.CreateStudentMenu();
            break;
    }
} while (true);