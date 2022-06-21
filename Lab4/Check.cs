namespace Lab4;

public class Check
{
    public Guid Id { get; set; }
    public DateTimeOffset DateTime { get; set; }
    public ICollection<Product> Products { get; set; }
}