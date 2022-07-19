using Bogus;

namespace Arrays_and_collections;

public class CartGenerator
{
    public static Cart CreateCart()
    {
        var cart = new Cart();
        Random random = new Random();
        int productsCount = random.Next(1, Cart.maxProductsCount);
        for (int i = 0; i < productsCount; i++)
        {
            cart.products.Add(ProductGenerator.GenerateProduct());
        }

        return cart;
    }
}