using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            SKUProduct sKUProduct = new SKUProduct();
            List<SKUProduct> listofProducts = new List<SKUProduct>();

            Console.WriteLine("Enter total number of order");
            int numberOfUnits = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfUnits; i++)
            {
                Console.WriteLine("Please enter type of sku product A,B,C,D");
                string skuType = Console.ReadLine();
                SKUProduct product = sKUProduct.getProduct(skuType.ToUpper());
                listofProducts.Add(product);
                Console.WriteLine("Price of Product {0} is {1}", listofProducts[i].Id, listofProducts[i].Price);
            }            
        }
    }
}
