using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Lab_16._2
{
    class Program
    {
        
            static void Main(string[] args)
            {
                string jsonString = String.Empty;
                using (StreamReader sr = new StreamReader("../../../../Products.json"))
                {
                    jsonString = sr.ReadToEnd();
                }
                Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
                Product maxPrice = products[0];
                foreach (Product i in products)
                {
                    if (i.Price > maxPrice.Price)
                    {
                        maxPrice = i;
                    }
                }
                Console.WriteLine($"{maxPrice.Code} {maxPrice.Name} {maxPrice.Price}");
                Console.ReadKey();
            }
        
    }
}


