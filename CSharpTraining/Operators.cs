using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class Operators
    {
        public static void Main(string[] args)
        {
            int a, b, sum, sub, mul, div, mod;
            Console.Write("Enter the first number:");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter the second number:");
            int.TryParse(Console.ReadLine(), out b);

            // //Arithmatic Operators
            sum = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
            mod = a % b;
            Console.WriteLine("The sum of {0} and {1} is :{2}", a, b, sum);
            Console.WriteLine("The sub of {0} and {1} is :{2}", a, b, sub);
            Console.WriteLine("The mul of {0} and {1} is :{2}", a, b, mul);
            Console.WriteLine("The div of {0} and {1} is :{2}", a, b, div);
            Console.WriteLine("The mod of {0} and {1} is :{2}", a, b, mod);

            // //Comparison Operators.

            if (a > b)
            {
                Console.WriteLine("{0} is greater than {1}", a, b);
            }
            else if (a >= b)
            {
                Console.WriteLine("{0} is greater than or equal to {1}", a, b);
            }
            else if (a < b)
            {
                Console.WriteLine("{0} is lesser than {1}", a, b);
            }
            else if (a <= b)
            {
                Console.WriteLine("{0} is lesser than or equal {1}", a, b);
            }
            else if (a == b)
            {
                Console.WriteLine("{0} is equal to {1}", a, b);
            }

            // //Logical Operators.
            if ((a > 1) && (a < b))
            {
                Console.WriteLine("Value of A is from 1 to {0}", b);
            }
            else if ((a >= 1) || (a >= b))
            {
                Console.WriteLine("Value of A is from 1 to {0}", b);
            }

            else if (a != b)
            {
                Console.WriteLine("Value of A is not equal to B");
            }

            // //Incremental and Decremental Operator.
            int i = 10;
            a = i++;
            Console.WriteLine("Post Increment : {0}", a);
            int j = ++a;
            Console.WriteLine("Pre Increment : {0}", a);

            //Terniary Operator.
            int age = 18;
            string validity = age >= 18 ? "valid" : "invalid";
            Console.WriteLine($"{age} is a {validity} age for Voting");
        }
    }
}
