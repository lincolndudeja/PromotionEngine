using PromotionEngine.BusinessLogic.Models;
using PromotionEngine.BusinessLogic.PromotionServiceContracts;
using PromotionEngine.BusinessLogic.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.BusinessLogic.PromotionServices
{
    public class PromotionServiceA : IPromotionService
    {
        public int GetTotalPrice(List<SkuProductCart> skuProductCarts)
        {
            int amount = 0;
            Dictionary<string, int> rulesDict = ActiveRules.GetRulesDict();
            foreach (var item in skuProductCarts)
            {
                switch (item.SkuProduct.SkuType)
                {
                    case "A": amount = amount + (item.Quantity / 3) * rulesDict["3A"] + (item.Quantity % 3) * item.SkuProduct.Price; break;
                    case "B": amount = amount + (item.Quantity / 2) * rulesDict["2B"] + (item.Quantity % 2) * item.SkuProduct.Price; break;
                }
            }

            return amount;
        }
    }
}
