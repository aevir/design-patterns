namespace DesignPatterns.Behavioural
{
    /*
     * Editor is the originator that creates a memento containing a snapshot of its current state and can restore its state from a memento.
     * EditorMemento is the memento that stores the state of the Editor.
     * EditorHistory is the caretaker that keeps track of the history of Editor states. It can save and restore the Editor state using mementos.
     */

    // Memento
    public class EditorMemento
    {
        public string Content { get; private set; }

        public EditorMemento(string content)
        {
            Content = content;
        }
    }

    // Originator
    public class Editor
    {
        public string Content { get; set; }

        public EditorMemento CreateMemento()
        {
            return new EditorMemento(Content);
        }

        public void RestoreMemento(EditorMemento memento)
        {
            Content = memento.Content;
        }
    }

    // Caretaker
    public class EditorHistory
    {
        private Stack<EditorMemento> history = new Stack<EditorMemento>();

        public void SaveState(Editor editor)
        {
            history.Push(editor.CreateMemento());
        }

        public void RestoreState(Editor editor)
        {
            if (history.Count > 0)
            {
                editor.RestoreMemento(history.Pop());
            }
        }
    }
}
