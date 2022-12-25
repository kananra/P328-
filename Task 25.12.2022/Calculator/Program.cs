using Calculator.Models;
using System.Diagnostics.Metrics;

Console.WriteLine("Welome to Calculator App");
string value;
do
{
    Console.WriteLine("Please enter numbers");
    Numbers num = new Numbers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    Console.WriteLine("Please enter symbol(/, +, -, *)");
    string symbol = Console.ReadLine();

    switch (symbol)
    {
        case "+":
            num.Sum();
            break;

        case "-":
            num.Difference();

            break;
        case "*":
            num.Multiply();
            break;

        case "/":
            num.Divide();
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
    Console.Write("Do you want to continue(y/n):");
    value = Console.ReadLine();
}
while (value == "y" || value == "Y");