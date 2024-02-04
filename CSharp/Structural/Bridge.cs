namespace DesignPatterns.Structural
{
    /*
     * IDevice is the Implementor interface, and TV and Radio are its concrete Implementors.
     * RemoteControl is the Abstraction, and BasicRemote is a Refined Abstraction.
     */

    // Implementor Interface
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }

    // Concrete Implementors
    public class TV : IDevice
    {
        public void TurnOn() => Console.WriteLine("Turning on the TV.");
        public void TurnOff() => Console.WriteLine("Turning off the TV.");
        public void SetChannel(int number) => Console.WriteLine($"Setting TV to channel {number}.");
    }

    public class Bridge_Radio : IDevice
    {
        public void TurnOn() => Console.WriteLine("Turning on the Radio.");
        public void TurnOff() => Console.WriteLine("Turning off the Radio.");
        public void SetChannel(int number) => Console.WriteLine($"Setting Radio to channel {number}.");
    }

    // Abstraction
    public abstract class Bridge_RemoteControl
    {
        protected IDevice device;

        protected Bridge_RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void SetChannel(int number);
    }

    // Refined Abstraction
    public class BasicRemote : Bridge_RemoteControl
    {
        public BasicRemote(IDevice device) : base(device) { }

        public override void TurnOn() => device.TurnOn();
        public override void TurnOff() => device.TurnOff();
        public override void SetChannel(int number) => device.SetChannel(number);
    }
}
