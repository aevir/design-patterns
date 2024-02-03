namespace DesignPatterns.Structural
{
    /*
     * IMessage is the component interface.
     * TextMessage is a concrete component implementing IMessage.
     * MessageDecorator is an abstract decorator implementing IMessage.
     * EncryptedMessage and HTMLMessage are concrete decorators extending MessageDecorator.
     */

    // Component Interface
    public interface IMessage
    {
        string Content { get; }
    }

    // Concrete Component
    public class TextMessage : IMessage
    {
        public string Content { get; }

        public TextMessage(string content)
        {
            Content = content;
        }
    }

    // Decorator
    public abstract class MessageDecorator : IMessage
    {
        protected IMessage message;

        protected MessageDecorator(IMessage message)
        {
            this.message = message;
        }

        public virtual string Content => message.Content;
    }

    // Concrete Decorators
    public class EncryptedMessage : MessageDecorator
    {
        public EncryptedMessage(IMessage message) : base(message) { }

        public override string Content => $"Encrypted({message.Content})";
    }

    public class HTMLMessage : MessageDecorator
    {
        public HTMLMessage(IMessage message) : base(message) { }

        public override string Content => $"<html><body>{message.Content}</body></html>";
    }
}
