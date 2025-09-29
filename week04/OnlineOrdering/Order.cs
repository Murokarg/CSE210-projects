using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order
    public double GetTotalCost()
    {
        double totalProducts = 0;
        foreach (Product product in _products)
        {
            totalProducts += product.GetTotalCost();
        }

        double shippingCost;
        if (_customer.LivesInUSA())
        {
            shippingCost = 5.0;
        }
        else
        {
            shippingCost = 35.0;
        }

        return totalProducts + shippingCost;
    }

    // Method to generate the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to generate the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }


}