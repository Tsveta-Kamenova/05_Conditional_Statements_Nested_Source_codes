namespace _03.NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double pricePerPiece = 0.0;
            double priceChange = 1.0;
            double finalPrice = 0.0;
            double sumLeft = 0.0;


            switch (typeOfFlowers)
            {
                case "Roses":
                    pricePerPiece = 5.0;
                    break;
                case "Dahlias":
                    pricePerPiece = 3.80;
                    break;
                case "Tulips":
                    pricePerPiece = 2.80;
                    break;
                case "Narcissus":
                    pricePerPiece = 3.0;
                    break;
                case "Gladiolus":
                    pricePerPiece = 2.50;
                    break;
                default:
                    Console.WriteLine("Invalid flower type.");
                    return;
            }

            double totalCost = flowersCount * pricePerPiece;

            if (flowersCount > 80 && typeOfFlowers == "Roses")
            {
                priceChange = 0.9; 
            }
            else if (flowersCount > 90 && typeOfFlowers == "Dahlias")
            {
                priceChange = 0.85;
            }
            else if (flowersCount > 80 && typeOfFlowers == "Tulips")
            {
                priceChange = 0.85;
            }
            else if (flowersCount < 120 && typeOfFlowers == "Narcissus")
            {
                priceChange = 1.15;
            }
            else if (flowersCount < 80 && typeOfFlowers == "Gladiolus")
            {
                priceChange = 1.20;
            }

            finalPrice = totalCost * priceChange;

            sumLeft = budget - finalPrice;

            if (sumLeft >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {typeOfFlowers} and {Math.Abs(sumLeft):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):F2} leva more.");
            }
        }
    }
}