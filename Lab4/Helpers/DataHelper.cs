namespace Lab4.Helpers;

public static class DataHelper
{
    private static readonly Random _random = new Random();

    public static Product GetRandomProduct()
    {
        var products = GetProducts();
        return products.ElementAt(_random.Next(products.Count));
    }

    private static ICollection<Product> GetProducts()
    {
        return new List<Product>()
        {
            new Product()
            {
                Name = "Chicken",
                Price = 100
            },
            new Product()
            {
                Name = "Egg",
                Price = 3
            },
            new Product()
            {
                Name = "Juice",
                Price = 50
            },
            new Product()
            {
                Name = "Banana",
                Price = 10
            },
            new Product()
            {
                Name = "Cucumber",
                Price = 8
            }
        };
    }
}