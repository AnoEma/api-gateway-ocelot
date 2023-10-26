namespace OrderProcessing.Product;

public class Product
{
    public Guid Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int Quantity_In_Stock { get; set; }
    public decimal Unit_Price { get; set; } = decimal.Zero;
}