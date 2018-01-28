using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobaTeaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var boba1 = new OrderBobaTea()
            {
                TypeofTea = TeaType.BlackTea,
                TypeofToppings = ToppingsType.Topioca,
                AmountofSugar = SugarAmount.Medium,
                IsIced = false,
                IsLargeSize = true,
                IsTakeout = true,
                CustomerName = "Cory",
                
            };
            Console.WriteLine(boba1.toString());
            Console.ReadKey(true);
        }
    }
}
