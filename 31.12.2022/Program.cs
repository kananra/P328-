using ConsoleApp3.Models;
using ConsoleApp3.Services.Implementations;

RoomService.Menu();
int num = int.Parse(Console.ReadLine());
RoomService roomService = new RoomService();

while (num != 4)
{
    switch (num)
    {
        case 1:
            Console.WriteLine("Please enter Room No and Price");
            roomService.Create(Room.GetNo(int.Parse(Console.ReadLine())),double.Parse(Console.ReadLine()));
            break;


        case 2:
            Room[] Rooms = roomService.GetAll();
            foreach (Room room in Rooms)
            {
                Console.WriteLine(room);
            }
            break;


        case 3:
            Console.WriteLine("Please enter Room Id");
            roomService.Rezerv(int.Parse(Console.ReadLine()));
            break;

    }
    Console.WriteLine("****************************");
    Console.WriteLine("****************************");
    Console.WriteLine("****************************");
    RoomService.Menu();
    num = int.Parse(Console.ReadLine());
    Console.Clear();

}
