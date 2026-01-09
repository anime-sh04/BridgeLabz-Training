using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class TextState
{
    public string Content;
    public TextState Prev;
    public TextState Next;

    public TextState(string content)
    {
        Content = content;
    }
}

class TextEditor
{
    private TextState head;
    private TextState tail;
    private TextState current;
    private int capacity;
    private int size;

    public TextEditor(int limit = 10)
    {
        capacity = limit;
    }

    // Add new state
    public void Type(string newContent)
    {
        TextState node = new TextState(newContent);

        // Clear redo history
        if (current != null && current.Next != null)
        {
            current.Next.Prev = null;
            current.Next = null;
            tail = current;
        }

        if (head == null)
        {
            head = tail = current = node;
        }
        else
        {
            tail.Next = node;
            node.Prev = tail;
            tail = current = node;
        }

        size++;
        if (size > capacity)
            RemoveOldest();
    }

    private void RemoveOldest()
    {
        head = head.Next;
        head.Prev = null;
        size--;
    }

    public void Undo()
    {
        if (current?.Prev != null)
            current = current.Prev;
        else
            Console.WriteLine("Nothing to undo");
    }

    public void Redo()
    {
        if (current?.Next != null)
            current = current.Next;
        else
            Console.WriteLine("Nothing to redo");
    }

    public void Display()
    {
        Console.WriteLine("\nCurrent Text:");
        Console.WriteLine(current?.Content ?? "");
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor(10);

        editor.Type("Hello");
        editor.Type("Hello World");
        editor.Type("Hello World!");
        editor.Display();

        editor.Undo();
        editor.Display();

        editor.Redo();
        editor.Display();

        editor.Type("Hello World!!");
        editor.Display();

        editor.Undo();
        editor.Undo();
        editor.Display();

        editor.Redo();
        editor.Display();
    }
}
