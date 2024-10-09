﻿using System;

namespace CSharpTraining
{
    class FunctionClass
    {
        //<Access_Specifier><Access_Modifier><Return_Type><Function_Name>(<List_of_Comma_Separated_Parameters>)
        /*
            Access Specifier: It is optional. If not specified, it is private.
            Access Modifier: It is also optional.Empty if not specified.
            Return Type: It is mandatory. Default should be provided as void.
            Function Name: 
                1. Any orbitrary name, but shoud not start with a number or special character.
                2. Same Function name can be repeated for implementing polymorphism.
            Parameters:
                1. Similar to a variable, but will not have access specifier.
                2. It could be of system defined type or user defined type.
        */
       
        void Message()
        {
            Console.Write("This is a Sample Function!");
        }

        private void Subract(int a, int b)
        {
            Console.WriteLine("The subraction of {0} and {1}  is {2}", a, b, a - b);
        }

        private void Subract(string a, string b)
        {
            int.TryParse(a, out int numericA);
            int.TryParse(b, out int numericB);
            //Console.WriteLine("The addition of {0} and {1}  is {2}", int.Parse(a), int.Parse(b), int.Parse(a) + int.Parse(b));
            Console.WriteLine("The addition of {0} and {1}  is {2}", numericA, numericB, numericA + numericB);
        }

        private void Subract(int a, int b, int c)
        {
            Console.WriteLine("The addition of {0} and {1} and {2}  is {3}", a, b, c, a + b + c);
        }

        private int Sum(int a, int b)
        {
            return a + b;
        }
        private decimal Add(decimal a,decimal b)
        {
            return a + b;
        }

        private static int Add(int a, int b,out int subraction)
        {
            subraction = a - b;
            return a + b;
        }

        //		//		Value parameter
        public static void Increment(int var2)
        {
            var2++;
        }
        //		Reference par ameter
        public static void Increment(ref int var3)
        {
            var3++;
        }

        public static void func(params int[] arr)
        {
            Console.WriteLine("No of elements in the array is {0}", arr.Length);
        }

        static void Main(string[] args)
        {

            FunctionClass objFunctions;
            objFunctions = new FunctionClass();
            
            objFunctions.Message();
            objFunctions.Add(10, 20);
            objFunctions.Subract("Akshaya", "Kumar");
            objFunctions.Add(10.00M, 11.00M);
            int y = objFunctions.Sum(10, 20);

            Console.WriteLine("The sum of {0} and {1} is {2}", 10, 20, objFunctions.Sum(10, 20));

            int var2 = 10;
            Console.WriteLine("Before fn call the value of var2 is {0}  ", var2);
            //			// Function call by value
            Increment(var2);
            Console.WriteLine("After fn call the value of var2 is {0}  ", var2);
            //			//						// Function call by Reference
            int var1 = 10;
            Increment(ref var1);
            Console.WriteLine("After fn call the value of var3 is {0}  ", var1);
            int a;
            string x;
            int b = Add(10, 20, out a);

            Console.WriteLine("The Value of result is {0}", b);
            Console.WriteLine("The Value of out parameter is {0}", a);
            func(new int[] { 1, 2, 3, 4 });
            func(1, 2,3,4);
            func(1, 2, 3, 4, 5, 6, 7, 8);
        }

    }
}
