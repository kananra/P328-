
internal class Product
{
    private string Name;
    private int Price;
    protected int Count;
    private int TotalIncome;
    private int Num;

    public Product(int count)
    {

        Count = count;


    }

    public void MinPrice(int price)
    {
        if (price > 0)
        {
            Price = price;
        }
        else
        {
            while (price < 1)
            {

                Console.WriteLine("Price can not be less than 1");
                Console.WriteLine("Please write again");
                int less = int.Parse(Console.ReadLine());
                price = less;

            }
        }
    }

    public void Null(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please enter your product name");
                string check = Console.ReadLine();
                name = check;
            }


        }
        else
        {
            Name = name;
        }


    }
    public int Sell(int num)
    {
        Num = num;
        while (num == 1)
        {
            if (Count > 0)
            {
                Count--;
                TotalIncome += Price;
                Console.WriteLine("If you want to sell again press 1");
                int newnum = int.Parse(Console.ReadLine());
                num = newnum;
            }
            else
            {
                Console.WriteLine("Out of Stock");
                Console.WriteLine($"Total income: {TotalIncome}$");
                
            }

            
        }
        return Count;

    }


}







