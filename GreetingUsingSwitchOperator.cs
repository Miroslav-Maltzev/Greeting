using System;

namespace Greeting
{
    public class Greeting
    {
        public static void Main(string[] args)
        {
            Console.Write("Hello! What is your name?");
            string name = Console.ReadLine();
            int hours = DateTime.Now.Hour;
            Console.Write(Answer(hours, name)); //If you want you can change variable "hours" to any number to debug
        }
        
        public static string Answer(int hours, string name)
        {
            string appeal = "";
            switch (hours)
            {
            case int h when h >= 9 && h < 12:
                appeal = "Good morning";
                break;
            case int h when h >= 12 && h < 15:
                appeal = "Good day";
                break;
            case int h when h >= 15 && h < 22:
                appeal = "Good evening";
                break;
            default:
                appeal = "Good night";
                break;
            }
            appeal = appeal + $", {name}!";
            return appeal;
        }
    }
}