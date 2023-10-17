namespace _4.FoodОrDrink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine() ?? "sushi";

            switch (product)
            {
                case "curry":
                case "noodles":
                case "sushi":
                case "spaghetti":
                case "bread":
                    Console.WriteLine("food"); break;
                case "tea":
                case "water":
                case "coffee":
                case "juice":
                    Console.WriteLine("drink"); break;
                default:
                    Console.WriteLine("unknown"); break;
            }
        }
    }
}