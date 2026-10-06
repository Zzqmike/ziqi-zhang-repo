namespace PaintOrderManagement.Models;
public class Order
{
    public DateTime CreatedAt { get; }
    public PaintProduct Product {get;set;}
    public int Quantity {get; set;}
    public decimal TotalPrice{get;set;}
    public Order(
        PaintProduct paintProduct,
        int quantity
    )
    {
        CreatedAt = DateTime.Now;
        Product = paintProduct;
        Quantity = quantity;
        TotalPrice = paintProduct.GetFinalPrice() * quantity;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Created At: {CreatedAt}");
        Console.WriteLine($"Product: {Product.Name}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Total Price: {TotalPrice}");
    }

    public decimal GetTotalPrice()
    {
        return TotalPrice;
    }

}