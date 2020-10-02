using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.BusinessLogic.Utility
{
    public class ActiveRules
    {
        /// <summary>
        /// Create a static method to fetch the rules present. Can pick up these from any file or database.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, int> GetRulesDict()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("3A", 130);
            dict.Add("2B", 45);
            dict.Add("CD", 30);
            return dict;
        }
    }
}
