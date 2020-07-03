using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class SKUProduct
    {
        public string Id { get; set; }
        public decimal Price { get; set; }

        public SKUProduct()
        {
        }

        public SKUProduct getProduct(string Productid)
        {
            SKUProduct product = new SKUProduct();            
            switch (Productid)
            {
                case "A":
                    product.Id = Productid;
                    product.Price = 50;                    

                    break;
                case "B":
                    product.Id = Productid;
                    product.Price = 30;                    

                    break;
                case "C":
                    product.Id = Productid;
                    product.Price = 20;                    

                    break;
                case "D":
                    product.Id = Productid;
                    product.Price = 15;                    
                    break;
            }
            return product;
        }

    }
}

