using Bogus;

namespace Arrays_and_collections;

public class ProductGenerator
{
    public static Product GenerateProduct()
    {
        var FakeProduct = new Faker<Product>()
            .RuleFor(pd => pd.Id, f => f.Random.Int(Product.minId, Product.maxId))
            .RuleFor(pd => pd.Category, f => f.Commerce.Categories(1)[0])
            .RuleFor(pd => pd.Name, f => f.Commerce.Product())
            .RuleFor(pd => pd.Price, f => Math.Round(f.Random.Double(Product.minPrice, Product.maxPrice), 2));
        return FakeProduct.Generate();
    }
}