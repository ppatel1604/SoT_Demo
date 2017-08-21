using System;

namespace Calculator_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            //BadCalculator();
            //UglyCalculator();
            IdealCalculator();

            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }

        private static void IdealCalculator()
        {
            var persister = new Calculator_Ideal.InMemoryPersister();

            new Calculator_Ideal.Calculator(new Calculator_Ideal.ConsoleLogger(), persister);
            new Calculator_Ideal.Calculator(new Calculator_Ideal.NullLogger(), persister);
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
