using System.Reflection;

class Person
{
    private int age = 21;
}
class AccessPrivateField
{
    static void Main()
    {
        Person person = new Person();
        Type type = typeof(Person);

        FieldInfo field = type.GetField("age",BindingFlags.Instance | BindingFlags.NonPublic);

        int currentAge =(int)field.GetValue(person);
        Console.WriteLine("Original Age: " + currentAge);
        field.SetValue(person,30);

        int updatedAge = (int)field.GetValue(person);
        Console.WriteLine("Updated Age: " + updatedAge);
    }
}