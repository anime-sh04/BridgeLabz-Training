using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

class UserNode
{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> Friends;   // List of Friend IDs
    public UserNode Next;

    public UserNode(int id, string name, int age)
    {
        UserID = id;
        Name = name;
        Age = age;
        Friends = new List<int>();
    }
}

class SocialNetwork
{
    private UserNode head;

    // Add User
    public void AddUser(int id, string name, int age)
    {
        UserNode newUser = new UserNode(id, name, age);
        newUser.Next = head;
        head = newUser;
    }

    // Find user
    private UserNode FindUser(int id)
    {
        UserNode temp = head;
        while (temp != null && temp.UserID != id)
            temp = temp.Next;
        return temp;
    }

    // Add friend connection
    public void AddFriend(int id1, int id2)
    {
        UserNode u1 = FindUser(id1);
        UserNode u2 = FindUser(id2);

        if (u1 == null || u2 == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        if (!u1.Friends.Contains(id2))
        {
            u1.Friends.Add(id2);
            u2.Friends.Add(id1);
            Console.WriteLine("Friend connection added.");
        }
    }

    // Remove friend connection
    public void RemoveFriend(int id1, int id2)
    {
        UserNode u1 = FindUser(id1);
        UserNode u2 = FindUser(id2);

        if (u1 == null || u2 == null) return;

        u1.Friends.Remove(id2);
        u2.Friends.Remove(id1);
        Console.WriteLine("Friend connection removed.");
    }

    // Mutual friends
    public void FindMutualFriends(int id1, int id2)
    {
        UserNode u1 = FindUser(id1);
        UserNode u2 = FindUser(id2);

        if (u1 == null || u2 == null) return;

        Console.WriteLine("\nMutual Friends:");

        foreach (int f in u1.Friends)
            if (u2.Friends.Contains(f))
                Console.WriteLine("User ID: " + f);
    }

    // Display friends of user
    public void DisplayFriends(int id)
    {
        UserNode user = FindUser(id);
        if (user == null) return;

        Console.WriteLine($"\nFriends of {user.Name}:");

        foreach (int f in user.Friends)
            Console.WriteLine("User ID: " + f);
    }

    // Search user
    public void Search(int id = -1, string name = "")
    {
        UserNode temp = head;
        while (temp != null)
        {
            if ((id != -1 && temp.UserID == id) ||
                (name != "" && temp.Name == name))
            {
                Console.WriteLine($"ID:{temp.UserID}, Name:{temp.Name}, Age:{temp.Age}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("User not found.");
    }

    // Count friends
    public void CountFriends()
    {
        UserNode temp = head;
        Console.WriteLine("\nFriend Count:");

        while (temp != null)
        {
            Console.WriteLine($"{temp.Name} has {temp.Friends.Count} friends.");
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        SocialNetwork net = new SocialNetwork();

        net.AddUser(1, "Alice", 22);
        net.AddUser(2, "Bob", 21);
        net.AddUser(3, "Charlie", 23);
        net.AddUser(4, "Daisy", 20);

        net.AddFriend(1, 2);
        net.AddFriend(1, 3);
        net.AddFriend(2, 3);
        net.AddFriend(3, 4);

        net.DisplayFriends(1);
        net.FindMutualFriends(1, 2);

        net.Search(name: "Charlie");

        net.CountFriends();

        net.RemoveFriend(1, 3);
        net.DisplayFriends(1);
    }
}
