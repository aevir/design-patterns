
namespace DesignPatterns.Creational
{
    /*
     * IComputerBuilder is the builder interface with methods to build different parts of a computer.
     * GamingComputerBuilder and OfficeComputerBuilder are concrete builders that implement the construction steps for different types of computers.
     * Computer is the product that is being built.
     * ComputerDirector is the director class that orchestrates the construction process.
     */

    // Product
    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }

        public void DisplayConfiguration()
        {
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"GPU: {GPU}");
            Console.WriteLine($"RAM: {RAM}");
        }
    }

    // Builder Interface
    public interface IComputerBuilder
    {
        void BuildCPU();
        void BuildGPU();
        void BuildRAM();
        Computer GetComputer();
    }

    // Concrete Builder
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();

        public void BuildCPU()
        {
            computer.CPU = "High-end CPU";
        }

        public void BuildGPU()
        {
            computer.GPU = "High-end GPU";
        }

        public void BuildRAM()
        {
            computer.RAM = "16GB";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }

    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();

        public void BuildCPU()
        {
            computer.CPU = "Mid-range CPU";
        }

        public void BuildGPU()
        {
            computer.GPU = "Integrated GPU";
        }

        public void BuildRAM()
        {
            computer.RAM = "8GB";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }

    // Director
    public class ComputerDirector
    {
        private IComputerBuilder computerBuilder;

        public ComputerDirector(IComputerBuilder builder)
        {
            computerBuilder = builder;
        }

        public void ConstructComputer()
        {
            computerBuilder.BuildCPU();
            computerBuilder.BuildGPU();
            computerBuilder.BuildRAM();
        }

        public Computer GetComputer()
        {
            return computerBuilder.GetComputer();
        }
    }
}
