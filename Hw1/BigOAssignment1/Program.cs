// See https://aka.ms/new-console-template for more information

using System;
using static System.Console;

namespace BigOAssignment1 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main()
        {
            ExampleClass t = new ExampleClass();
            t.ConstantEx();
            t.LinearEx();
            t.QuadraticEx();
            ReadKey();
        }
    }
}
