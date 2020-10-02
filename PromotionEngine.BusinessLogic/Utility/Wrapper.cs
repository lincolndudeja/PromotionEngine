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
        /// <summary>
        /// Calculate the amount on the basis of all the promotion types present
        /// </summary>
        /// <param name="skuProductCarts"></param>
        /// <returns></returns>
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
