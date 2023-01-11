using ConsoleApp6.Abstract;
using ConsoleApp6.Generic;
using ConsoleApp6.Models;

Generic<Instrument> generic= new Generic<Instrument>();

Console.WriteLine("         Flute           ");
Flute flute = new Flute();
flute.Sound();
generic.Print(new Flute());
Console.WriteLine("*******************");

Console.WriteLine("         Guitar           ");
Guitar guitar = new Guitar();
guitar.Sound();
generic.Print(new Guitar());
Console.WriteLine(generic);
Console.WriteLine("*******************");

Console.WriteLine("         Piano           ");
Piano piano = new Piano();
piano.Sound();
generic.Print(new Piano());
Console.WriteLine(generic);
Console.WriteLine("*******************");

Console.WriteLine("         Violin           ");
Violin violin = new Violin();
violin.Sound();
generic.Print(new Violin());
Console.WriteLine(generic);
Console.WriteLine("*******************");
