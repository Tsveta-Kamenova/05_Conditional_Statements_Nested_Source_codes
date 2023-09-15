namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse((Console.ReadLine()));
            string season = Console.ReadLine();

            string destination = "";
            string holidayType = "";
            double cost = 0.0;

            //switch (budget)
            //{
            //    case <= 100:
            //        switch (season)
            //        {
            //            case "summer":
            //                cost = 0.3;
            //                break;
            //            case "winter":
            //                cost = 0.7;
            //                break;
            //            default:
            //                Console.WriteLine("Invalid season.");
            //                return;
            //        }
            //        destination = "Bulgaria";
            //        break;

            //    case int n when n <= 1000 && n > 100:
            //        switch (season)
            //        {
            //            case "summer":
            //                cost = 0.4;
            //                break;
            //            case "winter":
            //                cost = 0.8;
            //                break;
            //            default:
            //                Console.WriteLine("Invalid season.");
            //                return;
            //        }
            //        destination = "Balkans";
            //        break;
            //    case > 1000:
            //        cost = 0.9;
            //        destination = "Europe";
            //        break;
            //    default:
            //        Console.WriteLine("Invalid budget.");
            //        return;
            //}

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    cost = 0.3;
                }
                else if (season == "winter")
                {
                    cost = 0.7;
                }
            }
            else if (budget <= 1000 && budget > 100)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    cost = 0.4;
                }
                else if (season == "winter")
                {
                    cost = 0.8;
                }
            }
            else 
            {
                cost = 0.9;
                destination = "Europe";
            }               

            if (season == "summer")
            {
                holidayType = "Camp";
                if (destination == "Europe")
                {
                    holidayType = "Hotel";
                }
            }
            else if (season == "winter")
            {
                holidayType = "Hotel";
            }

            double amountSpent = budget * cost;

            Console.WriteLine($"Somewhere in {destination}");

            Console.WriteLine($"{holidayType} - {amountSpent:F2}");
        }
    }
}