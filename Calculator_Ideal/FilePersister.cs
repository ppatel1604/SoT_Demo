using System.IO;

namespace Calculator_Ideal
{
    public class FilePersister : IPersister
    {
        public void PersistOperation(string operation)
        {
            File.AppendAllText("Database.txt", operation);
        }
    }
}