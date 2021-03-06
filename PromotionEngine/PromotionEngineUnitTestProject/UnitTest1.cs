﻿using System;
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
        public void GetTotalCost_1A1B1C()
        {
            List<SKUProduct> listofProducts = new List<SKUProduct>();
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                string skuType = string.Empty;
                if (count == 0)
                    skuType = "A";
                else if (count == 1)
                    skuType = "B";
                else if (count == 2)
                    skuType = "c";

                SKUProduct product = sKUProduct.getProduct(skuType.ToUpper());
                listofProducts.Add(product);
                count++;
            }

            int TotalCost = priceCalculator.GetTotalPrice(listofProducts);
            Assert.AreEqual(TotalCost, 100);
        }

        [TestMethod]
        public void GetTotalCost_5A5B1C()
        {
            List<SKUProduct> listofProducts = new List<SKUProduct>();
            int count = 0;
            for (int i = 0; i < 11; i++)
            {
                string skuType = string.Empty;
                if (count == 0 || count < 5)
                    skuType = "A";
                else if (count > 4 && count < 10)
                    skuType = "B";
                else if (count == 10)
                    skuType = "c";

                SKUProduct product = sKUProduct.getProduct(skuType.ToUpper());
                listofProducts.Add(product);
                count++;
            }

            int TotalCost = priceCalculator.GetTotalPrice(listofProducts);
            Assert.AreEqual(TotalCost, 370);
        }

        [TestMethod]
        public void GetTotalCost_3A5B1C1D()
        {
            List<SKUProduct> listofProducts = new List<SKUProduct>();
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                string skuType = string.Empty;
                if (count == 0 || count < 3)
                    skuType = "A";
                else if (count >= 3 && count <= 7)
                    skuType = "B";
                else if (count == 8)
                    skuType = "c";
                else if (count == 9)
                    skuType = "d";

                SKUProduct product = sKUProduct.getProduct(skuType.ToUpper());
                listofProducts.Add(product);
                count++;
            }

            int TotalCost = priceCalculator.GetTotalPrice(listofProducts);
            Assert.AreEqual(TotalCost, 280);
        }

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
