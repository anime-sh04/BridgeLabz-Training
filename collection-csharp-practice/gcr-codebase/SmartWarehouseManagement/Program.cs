class Program
{
    static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics
        {
            Name = "Laptop",
            Price = 75000,
            WarrantyYears = 2
        });

        Storage<Groceries> groceryStorage = new Storage<Groceries>();
        groceryStorage.AddItem(new Groceries
        {
            Name = "Milk",
            Price = 50,
            ExpiryDate = DateTime.Now.AddDays(5)
        });

        Storage<Furniture> furnitureStorage = new Storage<Furniture>();
        furnitureStorage.AddItem(new Furniture
        {
            Name = "Chair",
            Price = 2000,
            Material = "Wood"
        });

        electronicsStorage.DisplayAllItems();
        groceryStorage.DisplayAllItems();
        furnitureStorage.DisplayAllItems();
    }
}
