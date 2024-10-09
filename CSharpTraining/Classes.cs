using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    enum Choice
    {
        Add = 1,
        Sub = 2,
        Mul = 3,
        Div = 4
    }
    class Calculator
    {
        int a;
        int b;

        public Calculator()
        {
            this.a = 0;
            this.b = 20;
        }

        public Calculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        ~Calculator()
        {
            Console.WriteLine("Program Execution Competed!");
        }
        public void Calculate(Choice choice)
        {
            switch (choice)
            {
                case Choice.Add:
                    Console.WriteLine("The Sum of {0} and {1} is : {2}", a, b, a + b);
                    break;
                case Choice.Sub:
                    Console.WriteLine("The Subraction of {0} and {1} is : {2}", a, b, a - b);
                    break;
                case Choice.Mul:
                    Console.WriteLine("The Multiplication of {0} and {1} is : {2}", a, b, a * b);
                    break;
                case Choice.Div:
                    Console.WriteLine("The Division of {0} and {1} is : {2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Enter your Choice");
                    break;
            }
        }
    }

    class ExecuteCalculator
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the First Number:");
            int.TryParse(Console.ReadLine(), out int a);

            Console.Write("Enter the Second Number:");
            int.TryParse(Console.ReadLine(), out int b);

            Console.Write("Enter the Choice:");
            Enum.TryParse(Console.ReadLine(), true, out Choice c);
            Calculator calculator = new Calculator(a, b);
            calculator.Calculate(c);
        }
    }
}
