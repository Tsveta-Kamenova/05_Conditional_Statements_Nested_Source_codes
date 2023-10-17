namespace _002.EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else 
            { 
                Console.WriteLine("odd"); 
            }
        }
    }
}