namespace DesignPatterns.Structural
{
    /*
     * IGraphic is the component interface with operations like Move and Draw.
     * Circle and Rectangle are leaf objects implementing the IGraphic interface.
     * GraphicGroup is a composite object that can contain other IGraphic objects (circles, rectangles, or other groups), implementing the same interface.
     */

    // Component Interface
    public interface IGraphic
    {
        void Move(int x, int y);
        void Draw();
    }

    // Leaf
    public class Circle : IGraphic
    {
        public void Move(int x, int y)
        {
            Console.WriteLine($"Moving circle to ({x},{y})");
        }

        public void Draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }

    public class Rectangle : IGraphic
    {
        public void Move(int x, int y)
        {
            Console.WriteLine($"Moving rectangle to ({x},{y})");
        }

        public void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }

    // Composite
    public class GraphicGroup : IGraphic
    {
        private List<IGraphic> graphics = new List<IGraphic>();

        public void Add(IGraphic graphic)
        {
            graphics.Add(graphic);
        }

        public void Move(int x, int y)
        {
            foreach (var graphic in graphics)
            {
                graphic.Move(x, y);
            }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a group of graphics:");
            foreach (var graphic in graphics)
            {
                graphic.Draw();
            }
        }
    }
}
