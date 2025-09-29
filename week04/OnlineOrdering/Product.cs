using System;


public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to get the product's name
    public string GetName()
    {
        return _name;
    }

    // Method to get the product's ID
    public string GetProductId()
    {
        return _productId;
    }

    // Method to get the product's price
    public double GetPrice()
    {
        return _price;
    }

    // Method to get the product's quantity
    public int GetQuantity()
    {
        return _quantity;
    }

    // Method to get the total cost (price * quantity)
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    

}