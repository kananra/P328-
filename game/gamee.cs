


Console.WriteLine("         Menu            ");
Console.WriteLine("1.Gulleni tek-tek at");
Console.WriteLine("2.Gullenin hamısını birden at");
Console.WriteLine("3.Gulleni yeniden doldur");
Console.WriteLine("4.Oyundan cıx");
Console.WriteLine("5.Gulleni sayını goster");
int input;
int output;
input = int.Parse(Console.ReadLine());
output = Menu(input);



static int Menu(int menu)
{
    for (int bullet = 30; bullet >= 0;)
    {
        
        if (menu == 1)
        {
           
            bullet--;
            Console.WriteLine("Gulle atıldı");
            int first = int.Parse(Console.ReadLine());
            menu = first;
            continue;
            
        }
              else if (menu == 2)
              {

               bullet = 0;
               Console.WriteLine("Gulleni yeniden doldur");
               int first = int.Parse(Console.ReadLine());
               menu = first;
               continue;

              }

              else if (menu == 3)
              {

               bullet = 30;
               int first = int.Parse(Console.ReadLine());
               menu = first;

              }

              else if (menu == 4)
              {

               break;

              }

              else if (menu == 5)
              {

               Console.WriteLine(bullet);
               int first = int.Parse(Console.ReadLine());
               menu = first;

              }

              else if (bullet == 0)
              {

               Console.WriteLine("Gulleni yeniden doldur");
               int first = int.Parse(Console.ReadLine());
               menu = first;

               }
    else
    {

        Console.WriteLine("Reqemi duzgun daxil edin");
        int first = int.Parse(Console.ReadLine());
        menu = first;

    }

    }


    return menu;
}