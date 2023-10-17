namespace _012.CoffeeShopWithChecks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string orderedDrink = Console.ReadLine() ?? "tea";
            string orderedExtra = Console.ReadLine() ?? "no";

            double finalPrice = 0.0;
            bool validOrder = true;

            if (orderedDrink == "tea")
                finalPrice += 0.60;
            else if (orderedDrink == "coffee")
                finalPrice += 1.00;
            else
            {
                Console.WriteLine("Unknown drink");
                validOrder = false;
            }


            if (validOrder)
            {
                if (orderedExtra == "sugar")
                    finalPrice += 0.40;
                else if (orderedExtra == "no")
                    finalPrice += 0;
                else
                {
                    validOrder = false;
                    Console.WriteLine("Unknown extra");
                }
            }
            if (validOrder == true)
                Console.WriteLine($"Final price: ${finalPrice:f2}");

        }
    }
}
