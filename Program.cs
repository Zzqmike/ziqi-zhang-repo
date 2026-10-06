using PaintOrderManagement.Models;

namespace PaintOrderManagement;

public class Program
{
    public static void Main(string[] args)
    {
        PaintSpecification specification1 = new PaintSpecification("Black", 8);

        PaintSpecification specification2 = new PaintSpecification("White", 10);

        PaintProduct paint1 = new PaintProduct(
            "Black Base Coat",
            PaintType.BaseCoat,
            specification1,
            100m
        );

         PaintProduct paint2 = new PaintProduct(
            "White Glossy Paint",
            PaintType.Glossy,
            specification2,
            200m
        );

        paint1.DisplayInfo();
        paint2.DisplayInfo();

        Order order = new Order(paint2, 2);

        order.DisplayOrder();

    }
}
