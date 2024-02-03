namespace DesignPatterns.Creational
{
    /*
     * IChair, ISofa, and ITable are abstract product interfaces for different types of furniture.
     * ModernChair, ModernSofa, ModernTable, VictorianChair, VictorianSofa, and VictorianTable are concrete products, representing specific styles of furniture.
     * IFurnitureFactory is the abstract factory interface, with methods to create chairs, sofas, and tables.
     * ModernFurnitureFactory and VictorianFurnitureFactory are concrete factories that produce modern and Victorian-style furniture, respectively.
     */

    // Abstract Products
    public interface IChair
    {
        string Style { get; }
    }

    public interface ISofa
    {
        string Style { get; }
    }

    public interface ITable
    {
        string Style { get; }
    }

    // Concrete Products - Modern Style
    public class ModernChair : IChair
    {
        public string Style => "Modern Chair";
    }

    public class ModernSofa : ISofa
    {
        public string Style => "Modern Sofa";
    }

    public class ModernTable : ITable
    {
        public string Style => "Modern Table";
    }

    // Concrete Products - Victorian Style
    public class VictorianChair : IChair
    {
        public string Style => "Victorian Chair";
    }

    public class VictorianSofa : ISofa
    {
        public string Style => "Victorian Sofa";
    }

    public class VictorianTable : ITable
    {
        public string Style => "Victorian Table";
    }

    // Abstract Factory Interface
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ITable CreateTable();
    }

    // Concrete Factories
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();
        public ISofa CreateSofa() => new ModernSofa();
        public ITable CreateTable() => new ModernTable();
    }

    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new VictorianChair();
        public ISofa CreateSofa() => new VictorianSofa();
        public ITable CreateTable() => new VictorianTable();
    }
}
