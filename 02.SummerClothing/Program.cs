namespace _02.SummerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string shoes = "";
            string clothes = "";

            if (temp >= 10 && temp <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    clothes = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Evening")
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
            }

            else if (temp > 18 && temp <= 24)
            {
                if (timeOfDay == "Morning")
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Evening")
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
            }

            else if (temp >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Afternoon")
                {
                    clothes = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfDay == "Evening")
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                }
            }


            Console.WriteLine($"It's {temp} degrees, get your {clothes} and {shoes}.");
            }
        }
    }


