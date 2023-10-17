namespace _008.TicketPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();

            switch (ticketType)
            {
                case "student": Console.WriteLine("$1.00"); break;
                case "regular": Console.WriteLine("$1.60"); break;
                default: Console.WriteLine("Invalid ticket type!"); break;
            }
        }
    }
}