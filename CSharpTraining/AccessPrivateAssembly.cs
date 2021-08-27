using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateAssembly;

namespace CSharpTraining
{
   public class AccessPrivateAssembly
    {
        public static void Main(string[] args)
        {
            PrivateAssembly.Calculator calculator = new PrivateAssembly.Calculator();
            Console.WriteLine(calculator.Add(10, 20));
            Console.WriteLine(calculator.Subract(10, 20));
            Console.WriteLine(calculator.Multiply(10, 20));
            Console.WriteLine(calculator.Divide(10, 20));
        }
    }
}
