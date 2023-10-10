namespace myProduct
{
public interface IProduct
{
    string Name { get; }
    decimal Price { get; }
}

public class Product : IProduct
{
    public string Name { get; }
    public decimal Price { get; }

    public Product(string name, decimal price)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Product name must be non-empty.");
        }
        if (price <= 0)
        {
            throw new ArgumentException("Product price must be positive.");
        }

        this.Name = name;
        this.Price = price;
    }
}

}