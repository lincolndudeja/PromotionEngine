using PromotionEngine.BusinessLogic.Models;
using PromotionEngine.BusinessLogic.PromotionServiceContracts;
using PromotionEngine.BusinessLogic.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.BusinessLogic.PromotionServices
{
    class PromotionServiceB : IPromotionService
    {
        //Case For calculating amount id both Cand D type is present
        public int GetTotalPrice(List<SkuProductCart> skuProductCarts)
        {
            int amount = 0;

            var productCountByType = skuProductCarts.Where(x => x.SkuProduct.SkuType == "C" || x.SkuProduct.SkuType == "D").GroupBy(xy => xy.SkuProduct.SkuType)
                  .SelectMany(x => x.ToList()).ToList();
            switch (productCountByType.Count())
            {
                case 2:
                    var minQuantity = skuProductCarts.Where(x => x.SkuProduct.SkuType == "C" || x.SkuProduct.SkuType == "D").Min(x => x.Quantity);
                    var maxType = skuProductCarts.OrderByDescending(x => x.Quantity).FirstOrDefault();
                    amount = ActiveRules.GetRulesDict()["CD"] * minQuantity + (maxType.Quantity-minQuantity) * maxType.SkuProduct.Price;
                    break;
                case 1:
                    foreach (var item in skuProductCarts)
                    {
                        amount = amount + GetTotalPriceForIndividualUnit(item.SkuProduct, item.Quantity, ActiveRules.GetRulesDict());
                    }
                    break;
            }
            return amount;

        }
        //In case only C and D type Sku are there
        private int GetTotalPriceForIndividualUnit(SkuProduct product, int quantity, Dictionary<string, int> rulesDict)
        {
            int amount = 0;
            switch (product.SkuType)
            {
                case "D": return (quantity) * product.Price;
                case "C": return quantity * product.Price;
            }
            return amount;
        }
    }
}
