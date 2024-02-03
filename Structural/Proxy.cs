namespace DesignPatterns.Structural
{
    /*
     * IPrinter is the subject interface that both the real object and the proxy implement.
     * RealPrinter is the real subject that performs the actual operation (printing documents).
     * PrinterProxy is the proxy that controls access to the RealPrinter. It can add additional logic, like lazy initialization or access control, before forwarding requests to the RealPrinter.
     */

    // Subject Interface
    public interface IPrinter
    {
        void PrintDocument(string document);
    }

    // Real Subject
    public class RealPrinter : IPrinter
    {
        public void PrintDocument(string document)
        {
            Console.WriteLine($"Printing document: {document}");
        }
    }

    // Proxy
    public class PrinterProxy : IPrinter
    {
        private RealPrinter _realPrinter;

        public void PrintDocument(string document)
        {
            if (_realPrinter == null)
            {
                _realPrinter = new RealPrinter();
            }

            // Additional proxy logic, like lazy initialization or access control
            Console.WriteLine("Proxy: Additional logic before forwarding the print command.");
            _realPrinter.PrintDocument(document);
        }
    }
}
