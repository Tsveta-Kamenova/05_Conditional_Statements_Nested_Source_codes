namespace _09.SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string mark = Console.ReadLine();

            double price = 0;
            double totalSum = 0;
            int nights = daysToStay - 1;

            if (typeRoom == "room for one person")
            {
                price = nights * 118;
            }
            else if (typeRoom == "apartment")
            {
                if (daysToStay < 10)
                {
                    price = (nights * 155) * 0.7;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    price = (nights * 155) * 0.65;
                }
                else if (daysToStay > 15)
                {
                    price = (nights * 155) * 0.5;
                }
            }
            else if (typeRoom == "president apartment")
            {
                if (daysToStay < 10)
                {
                    price = (nights * 235) * 0.9;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    price = (nights * 235) * 0.85;
                }
                else if (daysToStay > 15)
                {
                    price = (nights * 235) * 0.8;
                }
            }

            if (mark == "positive")
            {
                price *= 1.25;
            }
            else if (mark == "negative")
            {
                price *= 0.90;
            }

            Console.WriteLine($"{price:f2}");

            //double daysToStay = double.Parse(Console.ReadLine());
            //string typeOfRoom = Console.ReadLine();
            //string assessment = Console.ReadLine();

            //double nightsToStay = 0.0;

            //if (daysToStay != 1 && daysToStay > 0)
            //{
            //    nightsToStay = daysToStay - 1;
            //}
            //else if (daysToStay > 1)
            //{
            //    nightsToStay = daysToStay;
            //}
            ////else
            ////{
            ////    Console.WriteLine("Error.");
            ////}

            //double discount = 0.0;
            //double priceRoom = 0.0;

            //if (typeOfRoom == "apartment")
            //{
            //    if (nightsToStay <= 10)
            //    {
            //        discount = 0.3;
            //    }
            //    else if (nightsToStay > 10 && nightsToStay < 15)
            //    {
            //        discount = 0.35;
            //    }
            //    else if (nightsToStay >= 15)
            //    {
            //        discount = 0.50;
            //    }
            //    priceRoom = 155.0;
            //}
            //else if (typeOfRoom == "president apartment")
            //{
            //    if (nightsToStay <= 10)
            //    {
            //        discount = 0.1;
            //    }
            //    else if (nightsToStay > 10 && nightsToStay < 15)
            //    {
            //        discount = 0.15;
            //    }
            //    else if (nightsToStay >= 15)
            //    {
            //        discount = 0.2;
            //    }
            //    priceRoom = 235.0;
            //}
            //else if (typeOfRoom == "room for one person")
            //{
            //    priceRoom = 118.0;
            //}
            ////else
            ////{
            ////    Console.WriteLine("Error.");
            ////}

            //double tipRatio = 1.0;

            //switch (assessment)
            //{
            //    case "positive":
            //        tipRatio = 1.25;
            //        break;
            //    case "negative":
            //        tipRatio = 0.9;
            //        break;
            //    //default:
            //    //    Console.WriteLine("Error.");
            //    //    return;
            //}

            //double discountPrice = nightsToStay * priceRoom * (1.0 - discount);
            //discountPrice *= tipRatio;

            //Console.WriteLine($"{discountPrice:F2}");

        }
    }
}