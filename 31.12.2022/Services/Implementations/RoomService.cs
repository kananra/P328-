using ConsoleApp3.Models;
using ConsoleApp3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3.Services.Implementations
{
    internal class RoomService : IRoomService
    {

        Hotel hotel = new Hotel();
        public void Create(int no, double price)
        {

            Room room = new Room
            {
                No = no,
                Price = price,
                IsRezerved = false

            };
            Array.Resize(ref hotel.Rooms, hotel.Rooms.Length + 1);
            hotel.Rooms[hotel.Rooms.Length - 1] = room;
        }

        public Room[] GetAll()
        {
            return hotel.Rooms;
        }

        public void Rezerv(int id)
        {
            for (int i = 0; i < hotel.Rooms.Length; i++)
            {
                if (hotel.Rooms[i].Id == id)
                {
                    Room room = hotel.Rooms[i];

                    if (room.IsRezerved == false)
                    {
                        Console.WriteLine("Room is empty");
                        Console.WriteLine("Please pay to room");
                        room.IsRezerved=true;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Room is rezerved");
                        return;
                    }

                }
               
        
            }

                    Console.WriteLine("Room is not find");
                    return;


        }


        public static void Menu()
        {
            Console.WriteLine($"Welome to The Lux Hotel");
            Console.WriteLine("1.Create room");
            Console.WriteLine("2.Show all room");
            Console.WriteLine("3.Rezerv room");
            Console.WriteLine("4.Exit hotel");

        }
    }


}
