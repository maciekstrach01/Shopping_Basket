
using System;
using System.Collections.Generic;
using System.Linq;
using myProduct;
using myCart;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            var product1 = new Product("Television", 2999.99m);
            var product2 = new Product("Smartphone", 5000);
            var product3 = new Product("Tablet", 799.99m);

            var cart = new Cart();

            cart = cart + product1;
            cart = cart + product2;
            cart = cart + product3;

            Console.WriteLine($"Total after adding {product1.Name}, {product2.Name}, and {product3.Name}: " + cart.CalculateTotal());

            cart = cart - product2;

            Console.WriteLine($"Total after removing {product2.Name}: " + cart.CalculateTotal());
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

