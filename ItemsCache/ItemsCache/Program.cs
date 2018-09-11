using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsCache
{
    class Program
    {
       public static void Main(string[] args)
        {
            GetProducts prod = new GetProducts();
            Console.WriteLine("List of Products");
            prod.DisplayProducts();
            Console.WriteLine("Enter the Id");
            int id = int.Parse(Console.ReadLine());
            prod.DisplayProductsById(id);
            Console.ReadLine();
        }
    }
}
