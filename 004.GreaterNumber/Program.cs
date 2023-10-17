namespace _004.GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine() ?? "0");
            int numberTwo = int.Parse(Console.ReadLine() ?? "0");

            if (numberOne > numberTwo)
                Console.WriteLine("Greater number: " + numberOne);
            else
                Console.WriteLine("Greater number: " + numberTwo);
        }
    }
}