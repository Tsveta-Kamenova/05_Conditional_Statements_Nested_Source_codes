namespace _18.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if ((number > 200 || number < 100) && number != 0)
                Console.WriteLine("invalid");

        }
    }
}