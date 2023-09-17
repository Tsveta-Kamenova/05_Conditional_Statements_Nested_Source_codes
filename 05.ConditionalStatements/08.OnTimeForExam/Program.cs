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
            int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;

            int differenceInMinutes = examTimeInMinutes - arrivalTimeInMinutes;

            string status = ""; // "Late" "On time"
            string comparison = ""; // "before" "after"


            if (differenceInMinutes>= 0  && differenceInMinutes <= 30)
            {
                status = "On time";
                comparison = "before";
            } else if (differenceInMinutes < 0)
            {
                status = "Late";
                comparison = "after";
                differenceInMinutes = -differenceInMinutes;
            } else
            {
                status = "Early";
                comparison = "before";
            }


            int compH = differenceInMinutes / 60;
            int compM = differenceInMinutes % 60;

            Console.WriteLine(status);
            if (compH > 0)
                Console.WriteLine($"{compH}:{compM:D2} hours {comparison} the start");
            else if (compM > 0)
                    Console.WriteLine($"{compM} minutes {comparison} the start");
                
        }
    }
}