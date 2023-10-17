namespace _13.BiggestOfFiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            int fifthNumber = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;

            if (firstNumber > maxNumber)
                maxNumber = firstNumber;
            if (secondNumber > maxNumber)
                maxNumber = secondNumber;
            if (thirdNumber > maxNumber)
                maxNumber = thirdNumber;
            if (fourthNumber > maxNumber)
                maxNumber = fourthNumber;
            if (fifthNumber > maxNumber)
                maxNumber = fifthNumber;

            Console.WriteLine(maxNumber);
        }
    }
}