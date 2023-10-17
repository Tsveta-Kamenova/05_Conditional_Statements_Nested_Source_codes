namespace _2.LargestNumberOutOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine() ?? "0");
            int secondNumber = int.Parse(Console.ReadLine() ?? "0");
            int thirdNumber = int.Parse(Console.ReadLine() ?? "0");

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                    Console.WriteLine(firstNumber);
                else Console.WriteLine(thirdNumber);
            }
            else 
            if (secondNumber > thirdNumber)
                Console.WriteLine(secondNumber);
            else
                Console.WriteLine(thirdNumber);
        }
    }
}