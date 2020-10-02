using PromotionEngine.BusinessLogic.Models;
using PromotionEngine.BusinessLogic.PromotionServiceContracts;
using PromotionEngine.BusinessLogic.PromotionServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.BusinessLogic.Utility
{
    public class Factory
    {
        public static IPromotionService GetPromotionService(PromotionType promotionType)
        {
            switch (promotionType)
            {
                case PromotionType.TypeA: return new PromotionServiceA();
                case PromotionType.TypeB: return new PromotionServiceB();
            }
            return null;
        }
    }
}
