using System.Collections.Generic;
using System.Linq;

class Product
{
    public string? Name { get; set; }
    public string? Category { get; set; }
    public decimal Price { get; set; }
    public static void TotalPrice(ILookup<string, Product> lookup)
    {
        foreach (var group in lookup)
        {
            foreach (var item in lookup[group.Key])
            {
                Console.WriteLine($"{item.Name} {item.Price}");
            }
            Console.WriteLine($"{group.Key} {group.Sum(x => x.Price)}");
        }

    }
}
static class ExtensionLookup
{
 
}


class MyProgram
{
    static void Main(string[] args)
    {
        var products = new List<Product>();
        products.Add(new Product { Name = "SmartTV", Price = 400, Category = "Electronics" });
        products.Add(new Product { Name = "Lenovo ThinkPad", Price = 1000, Category = "Electronics" });
        products.Add(new Product { Name = "Iphone", Price = 700, Category = "Electronics" });
        products.Add(new Product { Name = "Orange", Price = 2, Category = "Fruits" });
        products.Add(new Product { Name = "Banana", Price = 3, Category = "Fruits" });
        ILookup<string, Product> lookup = products.ToLookup(prod => prod.Category);
        Product.TotalPrice(lookup);
        Console.ReadKey();

    }

}