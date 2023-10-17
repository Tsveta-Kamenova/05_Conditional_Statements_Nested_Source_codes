using System.Globalization;

namespace _8.SortedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine() ?? "0");
            int secondNumber = int.Parse(Console.ReadLine() ?? "0");
            int thirdNumber = int.Parse(Console.ReadLine() ?? "0");

            if (firstNumber > secondNumber && secondNumber > thirdNumber)
                Console.WriteLine("Descending");
            else
            if (firstNumber < secondNumber && secondNumber < thirdNumber)
                Console.WriteLine("Ascending");
            else
                Console.WriteLine("Not sorted");
        }
    }
}