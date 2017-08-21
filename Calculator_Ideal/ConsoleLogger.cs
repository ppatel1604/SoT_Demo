using System;
using System.Collections.Generic;

namespace Calculator_Ideal
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintSomething()
        {
            Print(new[] {1, 2, 3, 4, 5});
            Print(new List<int> {1, 2, 3, 4, 5});
        }

        private void Print(IList<int> items)
        {
            
        }
    }
}