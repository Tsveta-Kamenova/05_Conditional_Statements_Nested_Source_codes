namespace _06.Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse((Console.ReadLine()));
            double n2 = double.Parse((Console.ReadLine()));
            string operation = Console.ReadLine();

            double resultDiv = n1 / n2;
            double remainder = n1 % n2;
            double resultSum = n1 + n2;
            double resultSumNeg = n1 - n2;
            double resultMultiply = n1 * n2;

            switch (operation)
            {
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} / {n2} = {resultDiv:F2}");
                    }    
                    
                    break;
                case "%":
                    if (n2 != 0)
                    {
                        Console.WriteLine($"{n1} % {n2} = {remainder}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    break;
                case "+":
                    if (resultSum % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {resultSum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {resultSum} - odd");
                    }
                    break;
                case "-":
                    if (resultSumNeg % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {resultSumNeg} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {resultSumNeg} - odd");
                    }
                    break;
                case "*":
                    if (resultMultiply % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {resultMultiply} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {resultMultiply} - odd");
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    return;
            }         
        }
    }
}