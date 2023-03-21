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
            string appeal = hours switch
            {
            int h when h >= 9 && h < 12 => "Good morning",
            int h when h >= 12 && h < 15 => "Good day",
            int h when h >= 15 && h < 22 => "Good evening",
            _ => "Good night"
            };
            appeal = appeal + $", {name}!";
            return appeal;
        }
    }
}