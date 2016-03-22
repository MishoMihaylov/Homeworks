using System;

public class Demo
{
    static void Main(string[] args)
    {
        ProductStorage<IProduct> kauflandDatabase = new ProductStorage<IProduct>();

        kauflandDatabase.Add(new Product(001, "Bread", "Chicho Gosho's bakery", 1.05m));
        kauflandDatabase.Add(new Product(002, "Chokolate for cooking", "It's not from Nestle and Kraft!", 1.85m));
        kauflandDatabase.Add(new Product(003, "Tomatoes", "Baba Penka's garden", 2.45m));
        kauflandDatabase.Add(new Product(004, "Cucumbers", "Baba Penka's garden", 2.05m));
        kauflandDatabase.Add(new Product(005, "Mineral Water", "Let's say unknown brand!", 0.85m));
        kauflandDatabase.Add(new Product(006, "Nuts mix", "Grandma Ginka", 2.45m));
        kauflandDatabase.Add(new Product(007, "Teflon pan", "Unknown brand", 22.99m));
        kauflandDatabase.Add(new Product(008, "Teflon pan", "Друга марка", 20.00m));
        kauflandDatabase.Add(new Product(009, "Chokolate for cooking", "Vegan chokolates", 3.05m));
        kauflandDatabase.Add(new Product(010, "Tomatoes", "Chicho Gosho's Garden", 2.45m));
        kauflandDatabase.Add(new Product(011, "Tomatoes", "Nakov's garden", 2.05m));
        kauflandDatabase.Add(new Product(012, "Raw chokolate", "It's not from Nestle and Kraft!", 1.85m));
        kauflandDatabase.Add(new Product(013, "Small Raw Chokolate", "It's not from Nestle and Kraft!", 1.05m));
        kauflandDatabase.Add(new Product(014, "Tomatoes", "Nakov's second garden", 2.85m));
        //kauflandDatabase.Add(new Product(011, "Remove Nakov's garden tomatos", "Remove test", 2.05m));

        Console.WriteLine("---Find By Title---\n\r");
        foreach (var currentProduct in kauflandDatabase.FindProductsByTitle("Tomatoes"))
        {
            Console.WriteLine(
                    $"Id {currentProduct.Id} \n\rTitle: {currentProduct.Title} \n\rSupplier: {currentProduct.Supplier} \n\rPrice: {currentProduct.Price} \n\r");
        }

        Console.WriteLine("--- End ---\n\r");

        Console.WriteLine("---Find By Title and Price---\n\r");
        foreach (var currentProduct in kauflandDatabase.FindProductsByTitleAndPrice("Tomatoes", 2.45m))
        {
            Console.WriteLine(
                    $"Id {currentProduct.Id} \n\rTitle: {currentProduct.Title} \n\rSupplier: {currentProduct.Supplier} \n\rPrice: {currentProduct.Price} \n\r");
        }

        Console.WriteLine("--- End ---\n\r");

        Console.WriteLine("---Find By Title and Price range---\n\r");
        foreach (var currentProduct in kauflandDatabase.FindProductsByTitleAndPriceRange("Tomatoes", 2.00m, 2.45m))
        {
            Console.WriteLine(
                    $"Id {currentProduct.Id} \n\rTitle: {currentProduct.Title} \n\rSupplier: {currentProduct.Supplier} \n\rPrice: {currentProduct.Price} \n\r");
        }

        Console.WriteLine("--- End ---\n\r");

        Console.WriteLine("---Find By Supplier and Price---\n\r");
        foreach (var currentProduct in kauflandDatabase.FindProductsBySupplierAndPrice("It's not from Nestle and Kraft!", 1.85m))
        {
            Console.WriteLine(
                    $"Id {currentProduct.Id} \n\rTitle: {currentProduct.Title} \n\rSupplier: {currentProduct.Supplier} \n\rPrice: {currentProduct.Price} \n\r");
        }

        Console.WriteLine("--- End ---\n\r");

        Console.WriteLine("---Find By Supplier and Price range---\n\r");
        foreach (var currentProduct in kauflandDatabase.FindProductsBySupplierAndPriceRange("It's not from Nestle and Kraft!", 1.0m, 2.0m))
        {
            Console.WriteLine(
                    $"Id {currentProduct.Id} \n\rTitle: {currentProduct.Title} \n\rSupplier: {currentProduct.Supplier} \n\rPrice: {currentProduct.Price} \n\r");
        }

        Console.WriteLine("--- End ---\n\r");
    }
}