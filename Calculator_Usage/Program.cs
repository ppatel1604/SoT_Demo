using System;

namespace Calculator_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            //BadCalculator();
            UglyCalculator();

            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }

        private static void UglyCalculator()
        {
            Calculator_Ugly.Calculator uglyCalculator = new Calculator_Ugly.Calculator();
            uglyCalculator.Add(4, 5);
            uglyCalculator.Add(10, 20);
            var result = uglyCalculator.Multiply(Int32.MaxValue, 2);
        }

        private static void BadCalculator()
        {
            Caculator_Bad.Calculator badCalculator = new Caculator_Bad.Calculator();
            badCalculator.Add(4, 5);
            badCalculator.Add(10, 20);
            var result = badCalculator.Multiply(Int32.MaxValue, 2);
        }
    }
}
