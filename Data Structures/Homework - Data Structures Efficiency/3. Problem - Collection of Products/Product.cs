using System;

public class Product : IComparable, IProduct
{
    private int id;
    private string title;
    private string supplier;
    private decimal price;

    public Product(int id, string title, string supplier, decimal price)
    {
        this.Id = id;
        this.Title = title;
        this.Supplier = supplier;
        this.Price = price;
    }

    public int Id
    {
        get
        {
            return this.id;
        }
        set
        {
            if(value <= 0)
            {
                throw new ArgumentOutOfRangeException("Id cannot be null or negative.");
            }

            this.id = value;
        }
    }

    public string Title
    {
        get
        {
            return this.title;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Title cannot be null or whitespaces.");
            }

            this.title = value;
        }
    }

    public string Supplier
    {
        get
        {
            return this.supplier;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Supplier cannot be null or whitespaces.");
            }

            this.supplier = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be null or negative.");
            }

            this.price = value;
        }
    }

    public int CompareTo(object obj)
    {
        Product comparedProduct = obj as Product;

        return this.Id.CompareTo(comparedProduct.Id);
    }
}