using System.Runtime.InteropServices;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 0.0;
            double discount = 0.0;
            double additionalDiscount = 0.0;

            int budget = int.Parse((Console.ReadLine()));
            string season = Console.ReadLine();
            int countFishermen = int.Parse(Console.ReadLine());


            //if (countFishermen < 7)
            //{
            //    discount = 0.1;
            //}
            //else if (countFishermen >= 7 && countFishermen <= 11)
            //{
            //    discount = 0.15;
            //}
            //else if (countFishermen > 11)
            //{
            //    discount = 0.25;
            //}

            //if (moneyLeft >= 0)
            //{
            //    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            //}
            //else
            //{
            //    Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):F2} leva.");
            //}


            switch (countFishermen)
            {
                case < 7:
                    discount = 0.1;
                    break;
                case  int n when n >= 7 && n <= 11:
                    discount = 0.15;
                    break;
                case  > 11:
                    discount = 0.25;
                    break;
                default:
                    Console.WriteLine("Invalid season.");
                    return;
            }


            switch (season)
            {
                case "Spring":
                    price = 3000.0;
                    break;
                case "Summer":
                    price = 4200.0;
                    break;
                case "Autumn":
                    price = 4200.0;
                    break;
                case "Winter":
                    price = 2600.0;
                    break;
                default:
                    Console.WriteLine("Invalid season.");
                    return;
            }

            double priceToPay = price * (1 - discount);

            if (countFishermen % 2 == 0 && season != "Autumn")
            {
                additionalDiscount = 0.05;
                priceToPay = priceToPay * (1 - additionalDiscount);
            }

            double moneyLeft = budget - priceToPay;


            switch (moneyLeft)
            {
                case >= 0:
                    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
                    break;
                case < 0:
                    Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):F2} leva.");
                    break;
            }



            


        }
    }
}