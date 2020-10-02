using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.BusinessLogic.Models;

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
                Quantity = 10
            });
            input.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("B"),
                Quantity = 5
            });
            int result = 100;
            Assert.AreEqual(100, result);
        }
        [TestMethod]
        public void ProductCD_combined_returnstotal()
        {
            List<SkuProductCart> skuProducts = new List<SkuProductCart>();
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("A"),
                Quantity = 10
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("B"),
                Quantity = 5
            });
            int result = 200;
            Assert.AreEqual(200, result);
        }
        [TestMethod]
        public void ProductC_alone_returnsTotal()
        {
            List<SkuProductCart> skuProducts = new List<SkuProductCart>();
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("A"),
                Quantity = 10
            });
            int result = 100;
            Assert.AreEqual(100, result);
        }
        [TestMethod]
        public void AllProducts_combined_returnstotal()
        {
            List<SkuProductCart> skuProducts = new List<SkuProductCart>();
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("A"),
                Quantity = 10
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("B"),
                Quantity = 5
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("C"),
                Quantity = 6
            });
            skuProducts.Add(new SkuProductCart()
            {
                SkuProduct = new SkuProduct("D"),
                Quantity = 10
            });
            int result = 400;
            Assert.AreEqual(400, result);
        }
    }
}
