using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

//Singleton Pattern
public sealed class Database
{
    private static Database database;

    private readonly List<Product> _products = new List<Product>();

    private Database() { }
    public static Database GetInstance()
    {
        if (database == null)
        {
            database = new Database();
        }

        return database;
    }
   
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public Product DeleteProductWithName(string name)
    {
        Product product = database?._products.Find(p => p.Name == name);
        if (product == null)
        {
            throw new InvalidOperationException();
        }

         _products.Remove(product);

        return product;

    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }

}

//Singleton Pattern