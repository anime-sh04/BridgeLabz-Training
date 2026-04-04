using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute :Attribute
{
    public int Value { get; }

    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

class User
{
    [MaxLength(10)]
    private string Username;

    public User(string username)
    {
        #pragma warning disable
        FieldInfo field = typeof(User).GetField(
            "Username",BindingFlags.Instance | BindingFlags.NonPublic);

        MaxLengthAttribute attr =
            (MaxLengthAttribute)Attribute.GetCustomAttribute(
                field, typeof(MaxLengthAttribute)
            );

        if (attr != null && username.Length > attr.Value)
        {
            throw new ArgumentException(
                $"Username cannot exceed {attr.Value} characters"
            );
        }

        Username = username;
    }

    public void Display()
    {
        Console.WriteLine("Username: " + Username);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            User u1 = new User("Animesh");
            u1.Display();

            User u2 = new User("AnimeshRajpoot");
            u2.Display();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}