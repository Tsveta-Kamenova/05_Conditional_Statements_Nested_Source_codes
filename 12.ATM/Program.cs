namespace _12.ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = int.Parse(Console.ReadLine());
            int withdraw = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            if (withdraw < limit && withdraw < balance)
                Console.WriteLine("The withdraw was successful.");
            if (withdraw > limit)
                Console.WriteLine("The limit was exceeded.");
            if (withdraw < limit && withdraw > balance)
                Console.WriteLine("Insufficient availability.");
        }
    }
}