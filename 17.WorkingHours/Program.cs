namespace _17.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourToCheck = int.Parse(Console.ReadLine());
            string dayToCheck = Console.ReadLine();

            bool isHourClosed = (hourToCheck < 10 || hourToCheck >= 18);
            bool isDayClosed = (dayToCheck == "Sunday");

            if (!isDayClosed && !isHourClosed)
                Console.WriteLine("open");
            else
                Console.WriteLine("closed");
        }
    }
}