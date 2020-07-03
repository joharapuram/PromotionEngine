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

            //A SKU
            Console.WriteLine("Please enter type of sku product A");
            string skuType = Console.ReadLine();
            SKUProduct product = sKUProduct.getProduct(skuType.ToUpper());
            listofProducts.Add(product);
            Console.WriteLine("Price of Product {0} is {1}", listofProducts[0].Id, listofProducts[0].Price);

            //B SKU
            Console.WriteLine("Please enter type of sku product B");
            string skuTypeB = Console.ReadLine();
            SKUProduct productB = sKUProduct.getProduct(skuTypeB.ToUpper());
            listofProducts.Add(productB);
            Console.WriteLine("Price of Product {0} is {1}", listofProducts[1].Id, listofProducts[1].Price);
            Console.ReadLine();
        }
    }
}
