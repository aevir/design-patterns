namespace DesignPatterns.Behavioural
{
    /*
     * CommunicationMediator is the concrete mediator that coordinates communication between User objects.
     * CommsUser is an abstract communications user class. Pilot is a concrete implementation of a CommsUser that takes part in a communication channel.
     * The Send method in Pilot sends a message through the mediator instead of communicating directly with other users.
     */

    // Mediator interface
    public interface ICommunicationMediator
    {
        void SendMessage(string message, string userId);
        void AddUser(CommsUser user);
    }

    // Concrete Mediator
    public class CommunicationMediator : ICommunicationMediator
    {
        private Dictionary<string, CommsUser> userMap = new Dictionary<string, CommsUser>();

        public void AddUser(CommsUser user)
        {
            userMap[user.Id] = user;
        }

        public void SendMessage(string message, string senderId)
        {
            foreach (var userId in userMap.Keys)
            {
                if (userId != senderId) // Sending the message to everyone except the sender
                {
                    userMap[userId].Receive(message);
                }
            }
        }
    }

    // CommsUser
    public abstract class CommsUser
    {
        protected ICommunicationMediator mediator;
        public string Id { get; private set; }

        public CommsUser(ICommunicationMediator mediator, string id)
        {
            this.mediator = mediator;
            this.Id = id;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }

    // Concrete CommsUser
    public class Pilot : CommsUser
    {
        public Pilot(ICommunicationMediator mediator, string id) : base(mediator, id) { }

        public override void Send(string message)
        {
            Console.WriteLine($"{Id}: Sending Message: {message}");
            mediator.SendMessage(message, Id);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{Id}: Received Message: {message}");
        }
    }
}
