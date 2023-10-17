namespace _009.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            switch (figureType)
            {
                case "square":
                    double side = double.Parse(Console.ReadLine());
                    double area = side * side;
                    Console.WriteLine($"{area:F2}");
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double length = double.Parse(Console.ReadLine());
                    area = width * length;
                    Console.WriteLine($"{area:F2}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    Console.WriteLine($"{area:F2}");
                    break;
                default: Console.WriteLine("Invalid figure."); break;
            }
        }
    }
}