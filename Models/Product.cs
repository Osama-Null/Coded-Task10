using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleT10.Models
{
    public class Product
    {
        public string proN;
        public float proP;
        public int proQ;

        public string GetProduct(string proName)
        {
            return $">> Product name: {proName}";
        }
        public string GetProduct(string proName, float proPrice)
        {
            return $">> Product name: {proName} | Product price: ${proPrice}";
        }
        public string GetProduct(string proName, float proPrice, int proQt)
        {
            proP = proPrice;
            proQ = proQt;

            return $">> Product name: {proName} | Product price: ${proPrice} | Qty: x{proQt}";
        }
        public void GetTotoal()
        {
            Console.WriteLine($"   Total: ${proP * proQ}");
        }

        //...................................................................................
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }
        public int Quan { get; set; }
        public float Sum { get; set; } = 0f;
        List<Product> proD = new List<Product>();

        public void AddPro(string proName, float proPrice, int proQt)
        {
            proD.Add(new Product { Name = proName, Price = proPrice, Quan = proQt });
        }
        public void GetProduct()
        {
            foreach (var element in proD)
            {
                Sum += (element.Price * element.Quan);
                Console.WriteLine($"{element.Name}\t\t\t${element.Price}\t\tx{element.Quan}\t\t${element.Price * element.Quan}");
            }
            Console.WriteLine($"\n>> Total price: ${Sum}");
        }
    }
}






