//Importing Namespaces
using System;

namespace ShrutiNameSpace
{
    class ShrutiClass
    {
        public static void Main(string[] args)
        {
            //Console.Write("Shruti, Welcome to C#\n");
            //Console.WriteLine("Welcome to CSharp!");

            Console.WriteLine("{0}, welcome to {1}. Today is {2}", "Shruti", "C#","Wednesday");
            Console.WriteLine($"{"Shruti"},welcome to {"C#"}. Today is {"Wednesday"}");

            string name = "Shruti";
            string subject = "Shruti";
            string day = "Shruti";

            //String Interopolation
            Console.WriteLine($"{name},welcome to {subject}. Today is {day}");

            name = Console.ReadLine();
            subject = Console.ReadLine();
            day = Console.ReadLine();
            Console.WriteLine("{0}, welcome to {1}. Today is {2}", name, subject, day);
            Console.WriteLine($"{name},welcome to {subject}. Today is {day}");

            Console.WriteLine("{0}, welcome to {1}. Today is {2}", args[0], args[1], args[2]);
        }
    }
}