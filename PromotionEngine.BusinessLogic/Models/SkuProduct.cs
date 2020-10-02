using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.BusinessLogic.Models
{
    public class SkuProduct
    {
        public String SkuType { get; set; }
        public int Price { get; set; }
        public PromotionType promotionType { get; set; }
        /// <summary>
        /// Used the constructor to initialize the type and price of individual units. Can create a function as well.
        /// </summary>
        /// <param name="skuType"></param>
        public SkuProduct(string skuType)
        {
            this.SkuType = skuType;
            switch (skuType)
            {
                case "A":
                    this.Price = 50;
                    this.promotionType = PromotionType.TypeA;
                    break;
                case "B":
                    this.Price = 30;
                    this.promotionType = PromotionType.TypeA;
                    break;
                case "C":
                    this.Price = 20;
                    this.promotionType = PromotionType.TypeB;
                    break;
                case "D":
                    this.Price = 15;
                    this.promotionType = PromotionType.TypeB;
                    break;
                default: throw new Exception("Invalid product type");
            }
        }
    }
    public enum PromotionType { TypeA,TypeB}
}
