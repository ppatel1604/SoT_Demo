using System;
using System.IO;
using Calculator;

namespace Calculator_Ugly
{
    public class Calculator/* : ICalculator*/
    {
        public int Add(int x, int y)
        {
            if (File.Exists("Database.txt"))
                File.AppendAllText("Database.txt", $"{x} + {y}");
            else
                File.WriteAllText("Database.txt", $"{x} + {y}");
            Console.WriteLine($"Adding two values <{x}> and <{y}>");
            return x + y;
        }

        public long Multiply(int x, int y)
        {
            if (File.Exists("Database.txt"))
                File.AppendAllText("Database.txt", $"{x} x {y}");
            else
                File.WriteAllText("Database.txt", $"{x} x {y}");
            Console.WriteLine($"Multiplying two values <{x}> and <{y}>");
            return (long) x * (long) y;
        }
    }
}
