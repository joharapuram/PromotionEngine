using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace PromotionEngineUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        SKUProduct sKUProduct = new SKUProduct();
        [TestMethod]
        public void getProductPrice()
        {
            string Id = "a";
            SKUProduct product = sKUProduct.getProduct(Id.ToUpper());
            Assert.AreEqual(50, product.Price);
        }
    }
}
