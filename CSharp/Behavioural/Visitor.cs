namespace DesignPatterns.Behavioural
{
    /*
     * IComputerPart and IComputerPartVisitor are the element and visitor interfaces, respectively.
     * Computer, Mouse, Keyboard, and Monitor are concrete elements implementing IComputerPart.
     * ComputerPartDisplayVisitor is a concrete visitor implementing IComputerPartVisitor.
     */

    // Visitor Interface
    public interface IComputerPartVisitor
    {
        void Visit(Computer computer);
        void Visit(Mouse mouse);
        void Visit(Keyboard keyboard);
        void Visit(Monitor monitor);
    }

    // Element Interface
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor computerPartVisitor);
    }

    // Concrete Elements
    public class Computer : IComputerPart
    {
        IComputerPart[] parts;

        public Computer()
        {
            parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            foreach (var part in parts)
            {
                part.Accept(computerPartVisitor);
            }
            computerPartVisitor.Visit(this);
        }
    }

    public class Mouse : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }

    public class Keyboard : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }

    public class Monitor : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }

    // Concrete Visitor
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void Visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer.");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Displaying Mouse.");
        }

        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying Keyboard.");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Displaying Monitor.");
        }
    }
}
