using ConsoleApp10.Models;
using ConsoleT10.Models;
using static System.Net.Mime.MediaTypeNames;

Product product = new Product();

string name;
float price;
int quan;

Console.Write("Enter product name: ");
name = Console.ReadLine();

Console.WriteLine(product.GetProduct(name));

//.................................................................
Console.Write("\nEnter product name: ");
name = Console.ReadLine();

Console.Write("Enter product price: $");
price = float.Parse(Console.ReadLine());

Console.WriteLine(product.GetProduct(name, price));

//.................................................................
Console.Write("\nEnter product name: ");
name = Console.ReadLine();

Console.Write("Enter product price: $");
price = float.Parse(Console.ReadLine());

Console.Write("Enter product quantity: x");
quan = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(product.GetProduct(name, price, quan));

//.................................................................
product.GetTotoal();

//.................................................................
int loop;

Console.Write("\n\nNumbers of products you want to add: ");
loop = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < loop; i++)
{
    Console.Write($"\n\nProduct {i + 1} name: ");
    name = Console.ReadLine();

    Console.Write($"Product {i + 1} price: $");
    price = float.Parse(Console.ReadLine());

    Console.Write($"Quantity: x");
    quan = Convert.ToInt32(Console.ReadLine());

    product.AddPro(name, price, quan);
}
Console.WriteLine("\n\nName\t\t\tPrice\t\tQuantity\tPrice\n_____________________________________________________________________________");
product.GetProduct();