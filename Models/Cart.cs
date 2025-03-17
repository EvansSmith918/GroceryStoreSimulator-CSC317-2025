namespace GroceryStoreSimulator;
public class Cart
{
    public List<Product> Items { get; set; } = new List<Product>();
    public decimal Total { get; set; }
}
