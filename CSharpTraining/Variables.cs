using System;

namespace CSharpTraining
{
    public class Variables
    {
        public static void Main(string[] args)
        {
            int i ;
            int a, b, sum;
            long l;
            string x;
            float f;
            double d;
            decimal dec;

            //Console.Write("Enter the first number:");
            //int.TryParse(Console.ReadLine(),out a);
            //Console.Write("Enter the second number:");
            //int.TryParse(Console.ReadLine(), out b);
            //sum = a + b;
            //Console.WriteLine("The sum of {0} and {1} is :{2}", a, b, sum);

            //Type Casting
            int.TryParse(Console.ReadLine(), out i);
            x = Console.ReadLine();
            f = 10;
            d = double.MaxValue;
            l = long.MaxValue;
            dec = decimal.MaxValue;

            x = Convert.ToString(i);
            i = (int)f;
            i = (int)l;
            l = i;
            d = f;
            f = (float)d;
            dec = (decimal)d;
            d = (double)dec;
        }
    }
}
