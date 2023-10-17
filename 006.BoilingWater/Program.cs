namespace _006.BoilingWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperarture = int.Parse(Console.ReadLine());

            if (temperarture > 100)
                Console.WriteLine("The water is boiling");
            else
                Console.WriteLine("The water is not hot enough");
        }
    }
}