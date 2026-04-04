abstract class WarehouseItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    public abstract void DisplayInfo();
}
