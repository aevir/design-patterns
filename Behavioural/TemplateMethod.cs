using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural
{
    /*
     * DataProcessor is the abstract class that defines the template method ProcessData and abstract methods ReadData, ProcessDataCore, and WriteData.
     * XmlDataProcessor and JsonDataProcessor are concrete classes that implement the abstract methods for XML and JSON data processing, respectively.
     */

    // Abstract Class
    public abstract class DataProcessor
    {
        // Template method
        public void ProcessData()
        {
            ReadData();
            ProcessDataCore();
            WriteData();
        }

        protected abstract void ReadData();
        protected abstract void ProcessDataCore();
        protected abstract void WriteData();
    }

    // Concrete Class
    public class XmlDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading XML Data.");
        }

        protected override void ProcessDataCore()
        {
            Console.WriteLine("Processing XML Data.");
        }

        protected override void WriteData()
        {
            Console.WriteLine("Writing XML Data.");
        }
    }

    public class JsonDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading JSON Data.");
        }

        protected override void ProcessDataCore()
        {
            Console.WriteLine("Processing JSON Data.");
        }

        protected override void WriteData()
        {
            Console.WriteLine("Writing JSON Data.");
        }
    }
}
