using PromotionEngine.BusinessLogic.Models;
using PromotionEngine.BusinessLogic.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of products");
            int no =Convert.ToInt16( Console.ReadLine());
            List<SkuProductCart> cartlist = new List<SkuProductCart>();
            try
            {
                for (int i = 0; i < no; i++)
                {
                    SkuProductCart cart = new SkuProductCart();
                    Console.WriteLine("Enter the product type");
                    String productType = Console.ReadLine();
                    Console.WriteLine("Enter the product Quantity");
                    int quantity = Convert.ToInt16(Console.ReadLine());
                    SkuProduct product = new SkuProduct(productType);
                    cart.Quantity = quantity;
                    cart.SkuProduct = product;
                    cartlist.Add(cart);
                }
                int total = Wrapper.GetTotalAmount(cartlist);
                Console.WriteLine("Total is: " + total);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some Exception occur...please try again");
            }
            Console.ReadKey();
        }
    }
}
