using PromotionEngine.BusinessLogic.Models;
using PromotionEngine.BusinessLogic.PromotionServiceContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PromotionEngine.BusinessLogic.Utility
{
    public class Wrapper
    {
        public static int GetTotalAmount(List<SkuProductCart> skuProductCarts)
        {
            int amount = 0;
            IPromotionService promotionService;
            foreach (PromotionType promotionType in Enum.GetValues(typeof(PromotionType)))
            {
                var typeAProducts = skuProductCarts.Where(x => x.SkuProduct.promotionType == promotionType).ToList();
                promotionService = Factory.GetPromotionService(promotionType);
                amount = amount + promotionService.GetTotalPrice(typeAProducts);
            }
            return amount;
        }
    }
}
