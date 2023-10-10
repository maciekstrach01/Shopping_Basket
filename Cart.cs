using myProduct;
namespace myCart
{
public interface ICart
{
    void AddProduct(IProduct product);
    void RemoveProduct(IProduct product);
    decimal CalculateTotal();
}

public class Cart : ICart
{
    private List<IProduct> products = new List<IProduct>();

    public void AddProduct(IProduct product)
    {
        if (product == null)
        {
            throw new ArgumentException("Product cannot be null.");
        }
        this.products.Add(product);
    }

    public void RemoveProduct(IProduct product)
    {
        if (product == null)
        {
            throw new ArgumentException("Product cannot be null.");
        }
        this.products.Remove(product);
    }

    public decimal CalculateTotal()
    {
        return this.products.Sum(product => product.Price);
    }

    public static Cart operator +(Cart cart, Product product)
    {
        cart.AddProduct(product);
        return cart;
    }

    public static Cart operator -(Cart cart, Product product)
    {
        cart.RemoveProduct(product);
        return cart;
    }
}

}