

internal class Product
{
    private string Name
    {

        get { return Name; }


        set
        {
            Name = value;

            if (string.IsNullOrEmpty(value))
            {
                while (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter your product name");
                    string check = Console.ReadLine();
                    value = check;
                }


            }


        }

    }

    private int Price
    {
        get { return Price; }


        set
        {

            Price = value;

            if (value > 0)
            {
                Price = value;
            }
            else
            {
                while (value < 1)
                {

                    Console.WriteLine("Price can not be less than 1");
                    Console.WriteLine("Please write again");
                    int less = int.Parse(Console.ReadLine());
                    value = less;

                }
            }


        }

    }

    protected int Count;
    private int TotalIncome;
    private int Num;

    public Product(int count)
    {

        Count = count;


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







