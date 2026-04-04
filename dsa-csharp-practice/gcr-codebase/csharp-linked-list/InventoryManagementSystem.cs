using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class ItemNode
{
    public int ItemID;
    public string ItemName;
    public int Quantity;
    public double Price;
    public ItemNode Next;

    public ItemNode(int id, string name, int qty, double price)
    {
        ItemID = id;
        ItemName = name;
        Quantity = qty;
        Price = price;
        Next = null;
    }
}

class Inventory
{
    private ItemNode head;

    // Add at beginning
    public void AddAtBeginning(int id, string name, int qty, double price)
    {
        ItemNode newNode = new ItemNode(id, name, qty, price);
        newNode.Next = head;
        head = newNode;
    }

    // Add at end
    public void AddAtEnd(int id, string name, int qty, double price)
    {
        ItemNode newNode = new ItemNode(id, name, qty, price);

        if (head == null)
        {
            head = newNode;
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
    }

    // Add at position
    public void AddAtPosition(int pos, int id, string name, int qty, double price)
    {
        if (pos <= 1)
        {
            AddAtBeginning(id, name, qty, price);
            return;
        }

        ItemNode temp = head;
        for (int i = 1; i < pos - 1 && temp.Next != null; i++)
            temp = temp.Next;

        ItemNode newNode = new ItemNode(id, name, qty, price);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    // Remove by Item ID
    public void Remove(int id)
    {
        if (head == null) return;

        if (head.ItemID == id)
        {
            head = head.Next;
            Console.WriteLine("Item removed.");
            return;
        }

        ItemNode temp = head;
        while (temp.Next != null && temp.Next.ItemID != id)
            temp = temp.Next;

        if (temp.Next == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }

        temp.Next = temp.Next.Next;
        Console.WriteLine("Item removed.");
    }

    // Update quantity
    public void UpdateQuantity(int id, int newQty)
    {
        ItemNode temp = head;
        while (temp != null && temp.ItemID != id)
            temp = temp.Next;

        if (temp == null)
            Console.WriteLine("Item not found.");
        else
        {
            temp.Quantity = newQty;
            Console.WriteLine("Quantity updated.");
        }
    }

    // Search
    public void Search(string name = "", int id = -1)
    {
        ItemNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if ((id != -1 && temp.ItemID == id) ||
                (name != "" && temp.ItemName == name))
            {
                Display(temp);
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No matching item found.");
    }

    // Total inventory value
    public void DisplayTotalValue()
    {
        ItemNode temp = head;
        double total = 0;

        while (temp != null)
        {
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }

        Console.WriteLine("Total Inventory Value: ₹" + total);
    }

    // Sorting
    public void SortByName(bool ascending = true)
    {
        for (ItemNode i = head; i != null; i = i.Next)
            for (ItemNode j = i.Next; j != null; j = j.Next)
                if ((ascending && i.ItemName.CompareTo(j.ItemName) > 0) ||
                    (!ascending && i.ItemName.CompareTo(j.ItemName) < 0))
                    Swap(i, j);
    }

    public void SortByPrice(bool ascending = true)
    {
        for (ItemNode i = head; i != null; i = i.Next)
            for (ItemNode j = i.Next; j != null; j = j.Next)
                if ((ascending && i.Price > j.Price) ||
                    (!ascending && i.Price < j.Price))
                    Swap(i, j);
    }

    private void Swap(ItemNode a, ItemNode b)
    {
        (a.ItemID, b.ItemID) = (b.ItemID, a.ItemID);
        (a.ItemName, b.ItemName) = (b.ItemName, a.ItemName);
        (a.Quantity, b.Quantity) = (b.Quantity, a.Quantity);
        (a.Price, b.Price) = (b.Price, a.Price);
    }

    public void DisplayAll()
    {
        ItemNode temp = head;
        Console.WriteLine("\nInventory:");

        while (temp != null)
        {
            Display(temp);
            temp = temp.Next;
        }
    }

    private void Display(ItemNode i)
    {
        Console.WriteLine($"ID:{i.ItemID}  Name:{i.ItemName}  Qty:{i.Quantity}  Price:{i.Price}");
    }
}

class Program
{
    static void Main()
    {
        Inventory inv = new Inventory();

        inv.AddAtEnd(1, "Keyboard", 5, 500);
        inv.AddAtEnd(2, "Mouse", 10, 300);
        inv.AddAtBeginning(3, "Monitor", 3, 7000);
        inv.AddAtPosition(2, 4, "USB Cable", 20, 150);

        inv.DisplayAll();

        inv.UpdateQuantity(2, 15);

        Console.WriteLine("\nSearch Item ID 1:");
        inv.Search(id: 1);

        inv.DisplayTotalValue();

        Console.WriteLine("\nSort by Price Descending:");
        inv.SortByPrice(false);
        inv.DisplayAll();

        Console.WriteLine("\nSort by Name Ascending:");
        inv.SortByName();
        inv.DisplayAll();

        inv.Remove(3);
        inv.DisplayAll();
    }
}
