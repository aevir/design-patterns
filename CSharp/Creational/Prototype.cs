
namespace DesignPatterns.Creational
{
    /*
     * IShapePrototype is the prototype interface with a Clone method.
     * Circle and Rectangle are concrete prototypes implementing IShapePrototype, which can clone themselves.
     */

    // Prototype Interface
    public interface IShapePrototype
    {
        IShapePrototype Clone();
    }

    // Concrete Prototype
    public class Prototype_Circle : IShapePrototype
    {
        public int Radius { get; set; }

        public Prototype_Circle(int radius)
        {
            Radius = radius;
        }

        public IShapePrototype Clone()
        {
            return new Prototype_Circle(Radius); // Cloning the Circle object
        }

        public void Display()
        {
            Console.WriteLine($"Circle with Radius: {Radius}");
        }
    }

    public class Prototype_Rectangle : IShapePrototype
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Prototype_Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public IShapePrototype Clone()
        {
            return new Prototype_Rectangle(Width, Height); // Cloning the Rectangle object
        }

        public void Display()
        {
            Console.WriteLine($"Rectangle with Width: {Width}, Height: {Height}");
        }
    }
}
