Console.WriteLine("Please enter product count");
Product product = new Product(int.Parse(Console.ReadLine()));
Console.WriteLine("Please enter your product price");
product.MinPrice(int.Parse(Console.ReadLine()));
Console.WriteLine("Please enter your product name");
product.Null(Console.ReadLine());
Console.WriteLine("If you want to sell product press 1");
product.Sell(int.Parse(Console.ReadLine()));
Milk milk = new Milk(int.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
