using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.BusinessLogic.Models;
using PromotionEngine.BusinessLogic.PromotionServiceContracts;
using PromotionEngine.BusinessLogic.Utility;

namespace PromotionEngine.UnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTestPromotionEngine
    {
        public UnitTestPromotionEngine()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
         [TestMethod]   
        public void ProductAB_Combined_returnstotal()
        {
            List<SkuProductCart> input = new List<SkuProductCart>();
            input.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("A"),
                Quantity = 5
            });
            input.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("B"),
                Quantity = 5
            });
            IPromotionService promotionService = Factory.GetPromotionService(PromotionType.TypeA);
            int result = promotionService.GetTotalPrice(input);
            Assert.AreEqual(350, result);
        }
        [TestMethod]
        public void ProductCD_combined_returnstotal()
        {
            List<SkuProductCart> skuProducts = new List<SkuProductCart>();
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("C"),
                Quantity = 2
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("D"),
                Quantity = 3
            });
            IPromotionService promotionService = Factory.GetPromotionService(PromotionType.TypeB);
            int result = promotionService.GetTotalPrice(skuProducts);
            Assert.AreEqual(75, result);
        }
        [TestMethod]
        public void ProductC_alone_returnsTotal()
        {
            List<SkuProductCart> skuProducts = new List<SkuProductCart>();
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("C"),
                Quantity = 5
            });
            IPromotionService promotionService = Factory.GetPromotionService(PromotionType.TypeB);
            int result = promotionService.GetTotalPrice(skuProducts);
            Assert.AreEqual(100, result);
        }
        [TestMethod]
        public void AllProducts_combined_returnstotal()
        {
            List<SkuProductCart> skuProducts = new List<SkuProductCart>();
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("A"),
                Quantity = 3
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("B"),
                Quantity = 5
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("C"),
                Quantity = 1
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("D"),
                Quantity = 1
            });
            int result = Wrapper.GetTotalAmount(skuProducts);
            Assert.AreEqual(280, result);
        }
        [TestMethod]
        public void AllProducts_combined_returnstotal_2()
        {
            List<SkuProductCart> skuProducts = new List<SkuProductCart>();
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("A"),
                Quantity = 5
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("B"),
                Quantity = 5
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("C"),
                Quantity = 1
            });
            int result = Wrapper.GetTotalAmount(skuProducts);
            Assert.AreEqual(370, result);
        }
        [TestMethod]
        public void AllProducts_combined_returnstotal_3()
        {
            List<SkuProductCart> skuProducts = new List<SkuProductCart>();
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("A"),
                Quantity = 1
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("B"),
                Quantity = 1
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("C"),
                Quantity = 1
            });
            int result = Wrapper.GetTotalAmount(skuProducts);
            Assert.AreEqual(100, result);
        }
    }
}
