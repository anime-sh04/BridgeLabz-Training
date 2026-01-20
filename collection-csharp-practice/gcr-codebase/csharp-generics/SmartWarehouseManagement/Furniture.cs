class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Furniture: {Name}, Price: {Price}, Material: {Material}");
    }
}
