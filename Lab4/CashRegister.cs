using System.Text;
using Lab4.Producers;

namespace Lab4;

public class CashRegister
{
    public Guid Id { get; init; }
    public IProducer Producer { get; init; }
    public IReadOnlyCollection<Product> Products => _products;

    public CashRegister(IProducer producer)
    {
        Id = Guid.NewGuid();
        Producer = producer;
    }

    public void AddProduct(Product product)
    {
        if (product is null)
            throw new ArgumentNullException(nameof(product), "Product cannot be null");
        _products.Add(product);
    }

    public void SaveCheck()
    {
        _checks.Enqueue(new Check()
        {
            Id = Guid.NewGuid(),
            DateTime = DateTimeOffset.Now,
            Products = new List<Product>(_products)
        });
        _products.Clear();
    }

    public string? PrintCheck()
    {
        if (_checks.Any())
        {
            var check = _checks.Dequeue();
            StringBuilder checkView = new StringBuilder();
            checkView.Append($"Check №{check.Id}\n");
            checkView.Append($"Date: {check.DateTime.LocalDateTime}\n");
            checkView.Append("Products:\n");
            foreach (var product in check.Products)
            {
                checkView.Append($"{product.Name} - {product.Price}\n");
            }
            checkView.Append($"Total price: {check.Products.Sum(p => p.Price)}\n");
            checkView.Append($"Cash register producer: {Producer}\n");
            checkView.Append($"Contacts:\n{Producer.GetContacts()}");
            return checkView.ToString();
        }
        return null;
    }
    
    private readonly List<Product> _products = new List<Product>();
    private readonly Queue<Check> _checks = new Queue<Check>();
}