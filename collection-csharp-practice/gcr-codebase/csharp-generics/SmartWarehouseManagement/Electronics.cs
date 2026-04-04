class Electronics : WarehouseItem
{
    public int WarrantyYears { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Electronics: {Name}, Price: {Price}, Warranty: {WarrantyYears} years");
    }
}
