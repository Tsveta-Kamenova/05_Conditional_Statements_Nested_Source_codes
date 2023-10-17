namespace _16.ProductOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double num3 = double.Parse(Console.ReadLine());

                int negativeCount = 0;
                int zeroCount = 0;

                if (num1 < 0)
                    negativeCount++;
                else if (num1 == 0)
                    zeroCount++;

                if (num2 < 0)
                    negativeCount++;
                else if (num2 == 0)
                    zeroCount++;

                if (num3 < 0)
                    negativeCount++;
                else if (num3 == 0)
                    zeroCount++;

                if (zeroCount > 0)
                {
                    Console.WriteLine("zero");
                }
                else if (negativeCount % 2 == 0)
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }
            }
        }
    }
}