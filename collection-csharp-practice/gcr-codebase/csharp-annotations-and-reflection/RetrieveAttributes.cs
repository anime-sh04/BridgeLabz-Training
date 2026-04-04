[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string authorName {get;}
    public AuthorAttribute(string name)
    {
        authorName = name;
    }
}

[Author("Animesh")]
class Ex
{
    public void Display()
    {
        Console.WriteLine("Hello!");
    }
}
class Program
{
    static void Main()
    {
        Type type = typeof(Ex);

        AuthorAttribute attr = (AuthorAttribute)Attribute.GetCustomAttribute(type,typeof(AuthorAttribute));
        if(attr!= null)
        {
            Console.WriteLine("Author :"+attr.authorName);
        }
    }
}