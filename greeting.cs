using System;

namespace Greeting
{
    public class Greeting
    {
        public static void Main(string[] args)
        {
            Console.Write("Hello! What is your name?");
            string name = Console.ReadLine();
            int hours = DateTime.Now.Hour + 3;
            Console.Write(Answer(hours, name)); //If you want you can change variable "hours" to any number to debug
        }
        
        public static string Answer(int hours, string name)
        {
            string appeal = "";
            if (hours >= 0 && hours < 12)
            {
                appeal = "Good morning";
            }
            else if (hours >= 12 && hours < 15)
            {
                appeal = "Good day";
            }
            else if (hours >= 15 && hours < 22)
            {
                appeal = "Good evening";
            }
            else if (hours >= 22 && hours < 24)
            {
                appeal = "Good night";
            }
            appeal = appeal + $", {name}!";
            return appeal;
        }
    }
}