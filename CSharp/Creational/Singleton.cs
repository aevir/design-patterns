
namespace DesignPatterns.Creational
{
    /*
     * Government is a singleton class. It has a private constructor and a static method GetInstance for getting the singleton instance.
     * The GetInstance method ensures that only one instance of the Government class is created. Subsequent calls to this method return the same instance.
     */

    // Singleton
    public class Government
    {
        private static Government instance;

        public string PresidentName { get; private set; }

        private Government(string presidentName)
        {
            PresidentName = presidentName;
        }

        public static Government GetInstance(string presidentName)
        {
            if (instance == null)
            {
                instance = new Government(presidentName);
            }
            return instance;
        }

        public void DisplayPresident()
        {
            Console.WriteLine($"The President is {PresidentName}");
        }
    }
}
