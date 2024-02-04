namespace DesignPatterns.Structural
{
    /*
     * Character is the flyweight class. Each Character object represents a character with a specific size, and these objects can be shared.
     * CharacterFactory is the flyweight factory. It creates new Character instances as needed and stores them for future references, ensuring that each character of a given size is instantiated only once.
     */

    // Flyweight
    public class Character
    {
        public char Symbol { get; }
        public int Size { get; }

        public Character(char symbol, int size)
        {
            Symbol = symbol;
            Size = size;
        }

        public void Display()
        {
            Console.WriteLine($"Character: {Symbol}, Size: {Size}");
        }
    }

    // Flyweight Factory
    public class CharacterFactory
    {
        private Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key, int size)
        {
            if (!characters.ContainsKey(key))
            {
                characters[key] = new Character(key, size);
            }
            return characters[key];
        }
    }
}
