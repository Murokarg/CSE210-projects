using System;


public class Customer
{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to get the customer's name
    public string GetName()
    {
        return _name;
    }

    // Method to get the customer's address
    public Address GetAddress()
    {
        return _address;
    }

    // Method to determine if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

}