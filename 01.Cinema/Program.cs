using System.Net.WebSockets;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeScreening = Console.ReadLine();
            int rowsCount = int.Parse(Console.ReadLine());
            int columnsCount = int.Parse(Console.ReadLine());


            double premierePrice = 12.00;
            double normalPrice = 7.50;
            double discountPrice = 5.00;

            double income = 0.0;

            int allSeats = rowsCount * columnsCount;
            
            if (typeScreening == "Premiere")
            {
                income = allSeats * premierePrice;
            }
            else if (typeScreening == "Normal")
            {
                income = allSeats * normalPrice;
            }
            else if (typeScreening == "Discount")
            {
                income = allSeats * discountPrice;
            }

            Console.WriteLine("{0:f2} leva",income);
        }
    }
}