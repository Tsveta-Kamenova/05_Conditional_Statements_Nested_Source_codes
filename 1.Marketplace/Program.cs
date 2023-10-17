namespace _1.Marketplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine() ?? "Kiwi";
            string day = Console.ReadLine() ?? "Weekday";
            
            double price = 0.0;

            if (product == "Kiwi")
            {
                if (day == "Weekday")
                    price += 2.20;
                else price += 3.00;
            }
            else if (product == "Banana")
            {
                if (day == "Weekday")
                    price += 2.50;
                else price += 2.70;
            }
            else if (product == "Apple")
            {
                if (day == "Weekday")
                    price += 1.30;
                else price += 1.60;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}