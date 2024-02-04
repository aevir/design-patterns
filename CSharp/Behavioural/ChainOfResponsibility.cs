namespace DesignPatterns.Behavioural
{
    /*
     * We have three handlers: TechnicalSupportHandler, BillingSupportHandler, and GeneralSupportHandler.
     * BaseHandler is an abstract class that implements the IHandler interface and includes the common SetNext method and nextHandler property, used across the three concrete handlers.
     * Each concrete handler extends BaseHandler and overrides the Handle method with its specific logic. It checks if it can handle the request; if not, it passes the request to the next handler.
     * SupportChain sets up the chain and processes requests.
     */

    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Handle(string request);
    }

    public abstract class BaseHandler : IHandler
    {
        protected IHandler? nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            nextHandler = handler;
            return handler;
        }

        public abstract void Handle(string request);
    }

    public class TechnicalSupportHandler : BaseHandler
    {
        public override void Handle(string request)
        {
            if (request == "Technical")
            {
                Console.WriteLine("Technical Support: Handling the technical request.");
            }
            else if (nextHandler != null)
            {
                nextHandler.Handle(request);
            }
        }
    }

    public class BillingSupportHandler : BaseHandler
    {
        public override void Handle(string request)
        {
            if (request == "Billing")
            {
                Console.WriteLine("Billing Support: Handling the billing request.");
            }
            else if (nextHandler != null)
            {
                nextHandler.Handle(request);
            }
        }
    }

    public class GeneralSupportHandler : BaseHandler
    {
        public override void Handle(string request)
        {
            Console.WriteLine($"General Support: Handling the request '{request}'.");
        }
    }

    public class SupportChain
    {
        public void ProcessRequest(string request)
        {
            // Building the chain of responsibility
            var technical = new TechnicalSupportHandler();
            var billing = new BillingSupportHandler();
            var general = new GeneralSupportHandler();

            technical.SetNext(billing).SetNext(general);

            technical.Handle(request);
        }
    }
}
