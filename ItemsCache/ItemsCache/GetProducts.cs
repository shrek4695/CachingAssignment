using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsCache
{
    public class GetProducts
    {
        Cache cacheobject = new Cache();
        public void DisplayProducts()
        {          
            var allproducts = cacheobject.GetAvailableProducts();
            Console.WriteLine("Product Id\tProduct Name\tProduct Price\tProduct Category");
            foreach(Products prod in allproducts)
            {
                Console.Write(prod.Id+"\t\t");
                Console.Write(prod.Name+"\t\t");
                Console.Write(prod.Price+"\t\t");
                Console.Write(prod.Category+"\t\t");
                Console.WriteLine();
            }
        }
        public void DisplayProductsById(int id)
        {
            var allproducts= cacheobject.GetAvailableProducts();
            Console.WriteLine("Product Id\tProduct Name\tProduct Price\tProduct Category");
            foreach (Products prod in allproducts)
            {
                if(prod.Id==id)
                {
                    Console.Write(prod.Id + "\t\t");
                    Console.Write(prod.Name + "\t\t");
                    Console.Write(prod.Price + "\t\t");
                    Console.Write(prod.Category + "\t\t");
                    Console.WriteLine();
                }
            }
        }
    }
}
