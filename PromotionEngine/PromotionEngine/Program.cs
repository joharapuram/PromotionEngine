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
            string skuType = "A";
            SKUProduct product = sKUProduct.getProduct(skuType.ToUpper());
            Console.WriteLine("Price of Product {0} is {1}", product.Id, product.Price);
            Console.ReadLine();
        }
    }
}
