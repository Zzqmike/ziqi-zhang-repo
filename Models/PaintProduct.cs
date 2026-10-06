using PaintOrderManagement.Interfaces;

namespace PaintOrderManagement.Models;

public class PaintProduct : IBuyable
{
    public readonly decimal TaxRate;
    public const decimal DefaultDiscount = 0.05m;
    public string Name { set; get; }
    public PaintType Type { get; set; }
    public PaintSpecification Specification { set; get; }
    public decimal Price {set; get; }

    public PaintProduct(
            string name,
            PaintType type,
            PaintSpecification specification,
            decimal price)
        {
            TaxRate = 0.10m;
            Name = name;
            Type = type;
            Specification = specification;
            Price = price;
        }

    public decimal GetFinalPrice()
        {
            decimal discountPrice = Price * (1-DefaultDiscount);
            decimal finalPrice = discountedPrice * (1 + TaxRate);
            return finalPrice;
        }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Type: {Type}");

        Specification.DisplaySpecification();

        Console.WriteLine($"Original Price: ${Price}");
        Console.WriteLine($"Final Price: ${GetFinalPrice()}");
    }

    public decimal GetMaxDiscount(int rate, bool isOverridable)
    {
        if (isOverridable)
        {
            return Price * rate / 100m;
        }

        return Price * DefaultDiscount;
    }



}