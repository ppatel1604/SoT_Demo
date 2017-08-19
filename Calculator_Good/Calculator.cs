using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Good
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            if ((x >= int.MaxValue && y > 0) || (y >= int.MaxValue && x > 0))
                throw new OverflowException($"Cannot add {x} and {y} as its result is large");

            PersistOperation($"{x} + {y}");
            Console.WriteLine($"Adding two values <{x}> and <{y}>");
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            if (Math.BigMul(x, y) > int.MaxValue)
                throw new OverflowException($"Cannot multiply {x} and {y} as its result is large");

            PersistOperation($"{x} x {y}");
            Console.WriteLine($"Multiplying two values <{x}> and <{y}>");
            return x * y;
        }

        private void PersistOperation(string operation)
        {
            File.AppendAllText("Database.txt", operation);
        }
    }
}
