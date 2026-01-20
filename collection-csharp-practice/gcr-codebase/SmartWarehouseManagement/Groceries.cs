class Groceries : WarehouseItem
{
    public DateTime ExpiryDate { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Grocery: {Name}, Price: {Price}, Expiry: {ExpiryDate.ToShortDateString()}");
    }
}
