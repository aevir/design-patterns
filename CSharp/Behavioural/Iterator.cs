namespace DesignPatterns.Behavioural
{
    /*
     * IBookCollection and IBookIterator are interfaces for the aggregate and iterator, respectively.
     * BookCollection is a concrete aggregate that stores books and can create an iterator for them.
     * BookIterator is a concrete iterator that provides sequential access to elements in the BookCollection.
     */

    // Aggregate Interface
    public interface IBookCollection
    {
        IBookIterator CreateIterator();
    }

    // Concrete Aggregate
    public class BookCollection : IBookCollection
    {
        private List<string> books = new List<string>();

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public IBookIterator CreateIterator()
        {
            return new BookIterator(this);
        }

        public int Count => books.Count;
        public string this[int index] => books[index];
    }

    // Iterator Interface
    public interface IBookIterator
    {
        string First();
        string Next();
        bool IsDone { get; }
        string CurrentItem { get; }
    }

    // Concrete Iterator
    public class BookIterator : IBookIterator
    {
        private readonly BookCollection _collection;
        private int _currentIndex;

        public BookIterator(BookCollection collection)
        {
            _collection = collection;
            _currentIndex = 0;
        }

        public string First()
        {
            _currentIndex = 0;
            return _collection[_currentIndex];
        }

        public string Next()
        {
            _currentIndex++;
            if (!IsDone)
                return _collection[_currentIndex];
            else
                return null;
        }

        public bool IsDone => _currentIndex >= _collection.Count;

        public string CurrentItem => _collection[_currentIndex];
    }
}
