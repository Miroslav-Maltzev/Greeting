using System;

namespace Greeting
{
    public class greeting
    {
        public static void Main(string[] args)
        {
            Console.Write("Hello! What is your name?");
            string name = Console.ReadLine();
            string time = Convert.ToString(DateTime.Now);
            int mins = Convert.ToInt32(time.Substring(14, 2));
            int hours = Convert.ToInt32(time.Substring(11, 2)) + 3; //+3 because of belarus timezone
            Console.Write(Answer(hours, mins, name)); //If you want you can change variables "hours" and "mins" to any numbers to debug
            
        }
        
        public static string Answer(int hours, int mins, string name)
        {
            string appeal = "";
            if (IsDateBetween(hours, mins, 0, 0, 12, 0))
            {
                appeal = "Good morning";
            }
            else if (IsDateBetween(hours, mins, 12, 0, 15, 0))
            {
                appeal = "Good day";
            }
            else if (IsDateBetween(hours, mins, 15, 0, 22, 0))
            {
                appeal = "Good evening";
            }
            else if (IsDateBetween(hours, mins, 22, 0, 24, 0))
            {
                appeal = "Good night";
            }
            appeal = appeal + $", {name}!";
            return appeal;
        }
        
        public static bool IsDateBetween(int dateHours, int dateMins, int date1Hours, int date1Mins, int date2Hours, int date2Mins)
        {
            int date = dateMins + dateHours*60;
            int date1 = date1Mins + date1Hours*60;
            int date2 = date2Mins + date2Hours*60;
            
            bool isBetween = false;
            if (date2 >= date && date >= date1)
            {
                isBetween = true;
            }
            return isBetween;
        }
    }
}