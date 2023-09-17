namespace _07.Hotel_room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double discountStudio = 0.0;
            double discountApartment = 0.0;

            double studioPrice = 0.0;
            double apartmentPrice = 0.0;

            // Discounts available more than 7
            if ((month == "May" || month == "October") && nights > 7)
            {
                discountStudio = 0.05;
            }

            // Discounts available more than 14
            if (nights >= 15)
            {
                if (month == "May" || month == "October")
                {
                    discountStudio = 0.30;
                }
                if (month == "June" || month == "September")
                {
                    discountStudio = 0.20;
                }
                discountApartment = 0.10;
            }
              


            // Price per type of room
            if (month == "May" || month == "October")
            {
                studioPrice = 50.0;
                apartmentPrice = 65.0;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76.0;
                apartmentPrice = 77.0;
            }

            double reducedPriceApartment = apartmentPrice * (1 - discountApartment);
            double reducedPriceStudio = studioPrice * (1 - discountStudio);

            double pricePerStayApartment = nights * reducedPriceApartment;
            double pricePerStayStudio = nights * reducedPriceStudio;

            Console.WriteLine($"Apartment: {pricePerStayApartment:F2} lv.");
            Console.WriteLine($"Studio: {pricePerStayStudio:F2} lv.");
        }
    }
}