namespace DesignPatterns.Behavioural
{
    /*
     * Television is the receiver, it knows how to perform the operations.
     * BaseCommand is an abstract class that implements the ICommand interface and includes the common tv property, used across the two concrete commands.
     * TurnOnTVCommand and TurnOffTVCommand are concrete commands inheriting from BaseCommand.
     * RemoteControl is the invoker; it takes commands and executes them.
     */

    // Command interface
    public interface ICommand
    {
        void Execute();
    }

    // Receiver
    public class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is off");
        }
    }

    // Base Command (abstract)
    public abstract class BaseCommand : ICommand
    {
        protected Television? tv;
        public abstract void Execute();
    }

    // Concrete Commands
    public class TurnOnTVCommand : BaseCommand
    {
        public TurnOnTVCommand(Television tv)
        {
            this.tv = tv;
        }

        public override void Execute()
        {
            tv.TurnOn();
        }
    }

    public class TurnOffTVCommand : BaseCommand
    {
        public TurnOffTVCommand(Television tv)
        {
            this.tv = tv;
        }

        public override void Execute()
        {
            tv.TurnOff();
        }
    }

    // Invoker
    public class Command_RemoteControl
    {
        public void Submit(ICommand command)
        {
            command.Execute();
        }
    }
}
