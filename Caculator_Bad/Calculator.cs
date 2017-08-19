using System;
using System.IO;
using Calculator;

namespace Caculator_Bad
{
    public class Calculator : ICalculator
    {
        public int Add(int x, int y)
        {
            File.WriteAllText("Database.txt", $"{x} + {y}");
            Console.WriteLine($"Adding two values <{x}> and <{y}>");
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            File.WriteAllText("Database.txt", $"{x} x {y}");
            Console.WriteLine($"Multiplying two values <{x}> and <{y}>");
            return x * y;
        }
    }
}
