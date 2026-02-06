class Passenger
{
    public int Age;
    public string Name;
    public Passenger(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public bool IsSenior()
    {
        return Age>= 60;
    }
}