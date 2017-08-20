using System;

namespace Calculator_Ideal
{
    public class Calculator
    {
        private readonly ILogger _logger;
        private readonly IPersister _persister;

        public Calculator(ILogger logger, IPersister persister)
        {
            _logger = logger;
            _persister = persister;
        }

        public int Add(int x, int y)
        {
            if ((x >= int.MaxValue && y > 0) || (y >= int.MaxValue && x > 0))
                throw new OverflowException($"Cannot add {x} and {y} as its result is large");

            _persister.PersistOperation($"{x} + {y}");
            _logger.Log($"Adding two values <{x}> and <{y}>");
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            if (Math.BigMul(x, y) > int.MaxValue)
                throw new OverflowException($"Cannot multiply {x} and {y} as its result is large");

            _persister.PersistOperation($"{x} x {y}");
            _logger.Log($"Multiplying two values <{x}> and <{y}>");
            return x * y;
        }
    }
}
