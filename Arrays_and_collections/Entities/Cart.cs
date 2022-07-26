namespace Arrays_and_collections;

public class Cart
{
    public static int maxProductsCount = 10;
    
    public List<Product> products = new List<Product>();

    public double CountPriceSum()
    {
        double sum = 0;
        foreach (var product in products)
        {
            sum += product.Price;
        }
        
        return Math.Round(sum, 2);
    }
}