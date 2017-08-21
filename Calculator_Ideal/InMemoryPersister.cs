using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Ideal
{
    public class InMemoryPersister : IPersister
    {
        private readonly StringBuilder _stringBuilder;

        public InMemoryPersister()
        {
            _stringBuilder = new StringBuilder();
        }

        public void PersistOperation(string operation)
        {
            _stringBuilder.AppendLine(operation);
        }

        public IEnumerable<string> AllOperations => _stringBuilder.ToString()
            .Split(new [] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
    }
}