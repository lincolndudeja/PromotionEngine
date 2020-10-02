using PromotionEngine.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.BusinessLogic.PromotionServiceContracts
{
    public interface IPromotionService
    {
        int GetTotalPrice(List<SkuProductCart> skuProductCarts);
    }
}
