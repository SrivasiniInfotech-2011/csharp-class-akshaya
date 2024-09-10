//Importing Namespaces
using System;

namespace AkshayaNameSpace
{
    class AkshayaClass
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args">Collection of Arguement Values.</param>
        public static void Main(string[] args)
        {
            /*Console.Write("Akshaya, Welcome to C#");
            Console.WriteLine("Welcome to CSharp!");

            Console.WriteLine("{0} Welcome to {1}. Today is Day Number: {2}", "Akshaya", "C#", 3);
            Console.WriteLine("{0}, welcome to {1}. Today is {2}", "Akshaya", "C#","Friday");
            Console.WriteLine($"{"Akshaya"},welcome to {"C#"}. Today is {"Wednesday"}");

            string name = "Akshaya";
            string subject = "C#";
            string day = "Wednesday";
            

            //String Interopolation
            Console.WriteLine($"{name},welcome to {subject}. Today is {day}");

            name = Console.ReadLine();
            subject = Console.ReadLine();
            day = Console.ReadLine();
            Console.WriteLine("{0}, welcome to {1}. Today is {2}", name, subject, day);
            Console.WriteLine($"{name},welcome to {subject}. Today is {day}");*/

            Console.WriteLine("{0}, welcome to {1}. Today is {2}", args[0], args[1], args[2]);

        }
    }
}