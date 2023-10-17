namespace _011.CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string orderedDrink = Console.ReadLine() ?? "tea";
            string orderedExtra = Console.ReadLine() ?? "no";

            double finalPrice = 0.0;

            if (orderedDrink == "tea")
                finalPrice += 0.60;
            else if (orderedDrink == "coffee")
                finalPrice += 1.00;

            if (orderedExtra == "sugar")
                finalPrice += 0.40;
            else if (orderedExtra == "no")
                finalPrice += 0;

            Console.WriteLine($"Final price: ${finalPrice:f2}");
        }
    }
}