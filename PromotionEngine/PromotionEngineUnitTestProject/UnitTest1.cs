using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace PromotionEngineUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        SKUProduct sKUProduct = new SKUProduct();
        PriceCalculator priceCalculator = new PriceCalculator();

        [TestMethod]
        public void getProductPrice()
        {
            string Id = "a";
            SKUProduct product = sKUProduct.getProduct(Id.ToUpper());
            Assert.AreEqual(50, product.Price);
        }

        [TestMethod]
        public void GetTotalCostWithCandDSKUPromotion()
        {
            List<SKUProduct> listofProducts = new List<SKUProduct>();
            listofProducts.Add(new SKUProduct() { Id = "A", Price = 50 });
            listofProducts.Add(new SKUProduct() { Id = "B", Price = 30 });
            listofProducts.Add(new SKUProduct() { Id = "C", Price = 20 });
            listofProducts.Add(new SKUProduct() { Id = "D", Price = 15 });
           
            int TotalCost = priceCalculator.GetTotalPrice(listofProducts);
            Assert.AreEqual(TotalCost, 110);
        }
    }
}
