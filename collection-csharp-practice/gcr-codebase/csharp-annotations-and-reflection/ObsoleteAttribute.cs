using System;

class LegacyAPI
{
    [Obsolete("OldFeature is obsolete. Use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("This is the old feature");
    }

    public void NewFeature()
    {
        Console.WriteLine("This is the new feature");
    }
}

class Program
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();

        api.OldFeature();
        api.NewFeature();
    }
}
