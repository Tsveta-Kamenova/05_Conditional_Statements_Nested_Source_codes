namespace _19.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secondsOne = int.Parse(Console.ReadLine());
            int secondsTwo = int.Parse(Console.ReadLine());
            int secondsThree = int.Parse(Console.ReadLine());

            int sumSeconds = secondsOne + secondsTwo + secondsThree;

            int minutes = sumSeconds / 60;
            int seconds = sumSeconds % 60;

            if (seconds <= 9)
                Console.WriteLine($"{minutes}:0{seconds}");
            else
                Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}