using System;

namespace Calculator_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            Caculator_Bad.Calculator badCalculator = new Caculator_Bad.Calculator();
            badCalculator.Add(4, 5);
            badCalculator.Add(10, 20);

            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
