using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpFeatures.Delegates
{
    public class ExampleDelegates
    {
        public ExampleDelegates()
        {
            var voidDelegate = new MyVoidDelegate(Sum);
            // its possible to add/delete any method that has the
            // same signature
            voidDelegate -= Sum;
            voidDelegate += Sum;
            voidDelegate += Sub;
            voidDelegate += Mult;
            voidDelegate += Div;
            voidDelegate += (x, y) => Console.WriteLine("Well, that is a lambda expression");

            voidDelegate(2, 2);
        }
        public static void Sum(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }
        public static void Sub(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }
        public static void Mult(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }
        public static void Div(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
        }
    }
}
