namespace _08.OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTimeInMinutes = examHour * 60 + examMinute;
            //600 for 10 a.m.
           
            int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;
            //631 for 10:31 a.m. //31 late
            //569 for 09:29 a.m. //-31 early

            int differenceInMinutes = arrivalTimeInMinutes - examTimeInMinutes;

            if (differenceInMinutes >= -30 && differenceInMinutes <= 0)
            {
                Console.WriteLine("On time");
            }
            else if (differenceInMinutes > 0)
            {
                Console.WriteLine("Late");
            }
            else if (differenceInMinutes < -30)
            {
                Console.WriteLine("Early");
            }

            //late
            if (differenceInMinutes > 0 && differenceInMinutes <= 60)
            {
                Console.WriteLine($"{Math.Abs(differenceInMinutes)} minutes after the start");
            }
            else if (differenceInMinutes > 60)
            {
                Console.WriteLine($"{differenceInMinutes / 60}:{differenceInMinutes % 60:D2} hours after the start");
            }

            //early
            else if (differenceInMinutes < 30 && differenceInMinutes > -60)
            {
                Console.WriteLine($"{Math.Abs(differenceInMinutes)} minutes before the start");
            }
            else if (differenceInMinutes <= -60)
            {
                Console.WriteLine($"{Math.Abs(differenceInMinutes / 60)}:{differenceInMinutes % 60:D2} hours before the start");
            }
        }
    }
}