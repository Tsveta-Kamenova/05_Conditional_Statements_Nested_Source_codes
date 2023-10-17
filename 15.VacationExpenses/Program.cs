namespace _15.VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accomodation = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double cost = 0.0;
            double discount = 0.0;

            switch (season)
            {
                case "Spring":
                    discount = 0.2;
                    switch (accomodation)
                    {
                        case "Hotel":
                            cost = 30.0;
                            break;
                        case "Camping":
                            cost = 10.0;
                            break;
                    }
                    break;
                case "Summer":
                    discount = 0.0;
                    switch (accomodation)
                    {
                        case "Hotel":
                            cost = 50.0;
                            break;
                        case "Camping":
                            cost = 30.0;
                            break;
                    }
                    break;
                case "Autumn":
                    discount = 0.3;
                    switch (accomodation)
                    {
                        case "Hotel":
                            cost = 20.0;
                            break;
                        case "Camping":
                            cost = 15.0;
                            break;
                    }
                    break;
                case "Winter":
                    discount = 0.1;
                    switch (accomodation)
                    {
                        case "Hotel":
                            cost = 40.0;
                            break;
                        case "Camping":
                            cost = 10.0;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid season.");
                    return;
            }
            cost *= days * (1 - discount);
            Console.WriteLine($"{cost:F2}");
        }
    }
}