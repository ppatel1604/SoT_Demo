using System.Collections;
using System.Collections.Generic;

namespace Calculator_Ideal
{
    public interface IPersister
    {
        void PersistOperation(string operation);

        IEnumerable<string> AllOperations { get; }
    }
}