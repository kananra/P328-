using System.Text.RegularExpressions;

Console.WriteLine("Zehmet olmasa sozu daxil edin");
string text = Console.ReadLine();
string result = Regex.Replace(text, @"[^\w\d]", ".");
Console.WriteLine(result);