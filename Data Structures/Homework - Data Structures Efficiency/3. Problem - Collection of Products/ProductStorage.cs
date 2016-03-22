using System.Collections.Generic;
using Wintellect.PowerCollections;

public class ProductStorage<T> where T : IProduct
{
    private OrderedDictionary<int, IProduct> productById;
    private OrderedDictionary<decimal, OrderedDictionary<int, IProduct>> productByPrice; //Ordered by Price range
    private OrderedDictionary<string, OrderedDictionary<int, IProduct>> productsByTitle; //Ordered by Title and Id
    private OrderedDictionary<string, OrderedDictionary<decimal, OrderedDictionary<int, IProduct>>> productsByTitleAndPrice; //Ordered by Title, Price and Id
    private OrderedDictionary<string, OrderedDictionary<decimal, OrderedDictionary<int, IProduct>>> productsBySupplierAndPrice; //Ordered by Supplier and Price

    public ProductStorage()
    {
        this.productById = new OrderedDictionary<int, IProduct>();
        this.productByPrice = new OrderedDictionary<decimal, OrderedDictionary<int, IProduct>>();
        this.productsByTitle = new OrderedDictionary<string, OrderedDictionary<int, IProduct>>();
        this.productsByTitleAndPrice = new OrderedDictionary<string, OrderedDictionary<decimal, OrderedDictionary<int, IProduct>>>();
        this.productsBySupplierAndPrice = new OrderedDictionary<string, OrderedDictionary<decimal, OrderedDictionary<int, IProduct>>>();
    }

    public void Add(IProduct product)
    {
        if (!this.productById.ContainsKey(product.Id))
        {
            this.productById.Add(product.Id, product);
        }
        else
        {
            var oldProduct = this.productById[product.Id];
            this.productById[product.Id] = product;
            this.productByPrice[oldProduct.Price].Remove(oldProduct.Id);
            if (this.productByPrice[oldProduct.Price] == null)
            {
                this.productByPrice.Remove(oldProduct.Price);
            }

            this.productsByTitle[oldProduct.Title].Remove(oldProduct.Id);
            if (this.productsByTitle[oldProduct.Title] == null)
            {
                this.productsByTitle.Remove(oldProduct.Title);
            }

            this.productsByTitleAndPrice[oldProduct.Title][oldProduct.Price].Remove(oldProduct.Id);
            if (this.productsByTitleAndPrice[oldProduct.Title][oldProduct.Price] == null)
            {
                this.productsByTitleAndPrice[oldProduct.Title].Remove(oldProduct.Price);
            }

            if (this.productsByTitleAndPrice[oldProduct.Title] == null)
            {
                this.productsByTitleAndPrice.Remove(oldProduct.Title);
            }

            this.productsBySupplierAndPrice[oldProduct.Supplier][oldProduct.Price].Remove(oldProduct.Id);
            if (this.productsBySupplierAndPrice[oldProduct.Supplier][oldProduct.Price] == null)
            {
                this.productsBySupplierAndPrice[oldProduct.Supplier].Remove(oldProduct.Price);
            }

            if (this.productsBySupplierAndPrice[oldProduct.Supplier] == null)
            {
                this.productsBySupplierAndPrice.Remove(oldProduct.Supplier);
            }
        }

        this.AddInProductByPrice(product);
        this.AddInProductsByTitleAndPrice(product);
        this.AddInProductsBySupplierAndPrice(product);
        this.AddInProductByTitle(product);
    }

    public bool RemoveById(int id)
    {
        return true;
    }

    private void AddInProductByPrice(IProduct product)
    {
        if (!this.productByPrice.ContainsKey(product.Price))
        {
            this.productByPrice.Add(product.Price, new OrderedDictionary<int, IProduct>());
        }

        this.productByPrice[product.Price].Add(product.Id, product);
    }

    private void AddInProductByTitle(IProduct product)
    {
        if (!this.productsByTitle.ContainsKey(product.Title))
        {
            this.productsByTitle.Add(product.Title, new OrderedDictionary<int, IProduct>());
        }

        this.productsByTitle[product.Title].Add(product.Id, product);
    }

    private void AddInProductsByTitleAndPrice(IProduct product)
    {
        if (!this.productsByTitleAndPrice.ContainsKey(product.Title))
        {
            this.productsByTitleAndPrice.Add(product.Title, new OrderedDictionary<decimal, OrderedDictionary<int, IProduct>>());
        }

        if (!this.productsByTitleAndPrice[product.Title].ContainsKey(product.Price))
        {
            this.productsByTitleAndPrice[product.Title].Add(product.Price, new OrderedDictionary<int, IProduct>());
        }

        this.productsByTitleAndPrice[product.Title][product.Price].Add(product.Id, product);
    }

    private void AddInProductsBySupplierAndPrice(IProduct product)
    {
        if (!this.productsBySupplierAndPrice.ContainsKey(product.Supplier))
        {
            this.productsBySupplierAndPrice.Add(product.Supplier, new OrderedDictionary<decimal, OrderedDictionary<int, IProduct>>());
        }

        if (!this.productsBySupplierAndPrice[product.Supplier].ContainsKey(product.Price))
        {
            this.productsBySupplierAndPrice[product.Supplier].Add(product.Price, new OrderedDictionary<int, IProduct>());
        }

        this.productsBySupplierAndPrice[product.Supplier][product.Price].Add(product.Id, product);
    }

    public List<IProduct> FindProductsByTitle(string title)
    {
        if (!this.productsByTitle.ContainsKey(title))
        {
            throw new KeyNotFoundException("Product with current title do not exist.");
        }

        List<IProduct> result = new List<IProduct>();

        foreach (var productByTitle in productsByTitle[title])
        {
            result.Add(productByTitle.Value);
        }

        return result;
    }

    public List<IProduct> FindProductsByTitleAndPrice(string title, decimal price)
    {
        if (!this.productsByTitleAndPrice.ContainsKey(title))
        {
            throw new KeyNotFoundException("Product with current title do not exist.");
        }

        if (!this.productsByTitleAndPrice[title].ContainsKey(price))
        {
            throw new KeyNotFoundException("Product with current price do not exist.");
        }

        List<IProduct> result = new List<IProduct>();

        foreach (var productByCurrentPrice in productsByTitleAndPrice[title][price])
        {
            result.Add(productByCurrentPrice.Value);
        }

        return result;
    }

    public List<IProduct> FindProductsByTitleAndPriceRange(string title, decimal from, decimal to)
    {
        if (!this.productsByTitleAndPrice.ContainsKey(title))
        {
            throw new KeyNotFoundException("Product with current title do not exist.");
        }

        List<IProduct> result = new List<IProduct>();

        var productByCurrentPriceRange = productsByTitleAndPrice[title].Range(from, true, to, true);

        foreach (var currentProductByPrice in productByCurrentPriceRange)
        {
            foreach (var currentProductById in currentProductByPrice.Value)
            {
                result.Add(currentProductById.Value);
            }
        }

        return result;
    }

    public List<IProduct> FindProductsBySupplierAndPrice(string supplier, decimal price)
    {
        if (!this.productsBySupplierAndPrice.ContainsKey(supplier))
        {
            throw new KeyNotFoundException("Product with current supplier do not exist.");
        }

        if (!this.productsBySupplierAndPrice[supplier].ContainsKey(price))
        {
            throw new KeyNotFoundException("Product with current price do not exist.");
        }

        List<IProduct> result = new List<IProduct>();

        foreach (var productsBySupplierAndPrice in productsBySupplierAndPrice[supplier][price])
        {
            result.Add(productsBySupplierAndPrice.Value);
        }

        return result;
    }

    public List<IProduct> FindProductsBySupplierAndPriceRange(string supplier, decimal from, decimal to)
    {
        if (!this.productsBySupplierAndPrice.ContainsKey(supplier))
        {
            throw new KeyNotFoundException("Product with current supplier do not exist.");
        }

        List<IProduct> result = new List<IProduct>();

        var productByCurrentPriceRange = productsBySupplierAndPrice[supplier].Range(from, true, to, true);

        foreach (var currentProductByPrice in productByCurrentPriceRange)
        {
            foreach (var currentProductById in currentProductByPrice.Value)
            {
                result.Add(currentProductById.Value);
            }
        }

        return result;
    }
}
