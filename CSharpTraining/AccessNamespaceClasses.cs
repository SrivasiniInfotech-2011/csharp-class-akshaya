
using Mynamespace;
using MyMath;

namespace CSharp
{
    class AccessNamespaceClasses
    {
        public static void Main(string[] args) {
            Routine.Add(1, 2, 3, 4, 5);
            Mynamespace.HelloWorld.SayHi();
            Testing.HelloWorld.TestMessage();
        }
    }
}
