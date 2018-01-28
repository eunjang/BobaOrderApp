using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobaTeaApp
{
    enum TeaType
    {
        BlackTea = 1,
        GreenTea,
        TaroTea,
        JasmineTea,
    }
    enum ToppingsType
    {
        Topioca =1,
        Jelly,
        Fruit,
    }
    enum SugarAmount
    {
        None=0,
        Little,
        Medium,
        Alot,
    }
    class OrderBobaTea
    {
        public OrderBobaTea()
        {
            OrderDateTime = DateTime.Now; // "UtcNow" is a Property. Shows the current date and time in Europe. "Now" is localized date and time. 
        }
        #region Properties
        /// <summary>
        /// Properties are unique account for the account.
        /// This is to order a perfect boba tea!
        /// </summary>
        public TeaType TypeofTea { get; set; }
        public ToppingsType TypeofToppings { get; set; }
        public SugarAmount AmountofSugar { get; set; } 
        public Boolean IsIced { get; set; } // hot or iced?
        public Boolean IsLargeSize { get; set; }
        public Boolean IsTakeout { get; set; }
        public decimal Balance { get { return IsLargeSize ? 6 : 5; }} // Property ? (value) : (value) = "If" statement
        public DateTime OrderDateTime { get; private set; }
        public string CustomerName { get; set; }
        #endregion

        #region Methods
        public string toString() // toString = take an object, it's represented as a String. Most objects have 'toString'.
        {
            var order = $"{CustomerName}'s Order:\t";
            if (IsLargeSize == true)
            {
                order += "Large";
            }
            else
            {
                order += "Medium";
            }

            if (IsIced == true)
            {
                order += " Iced";
            }
            else
            {
                order += " Hot";
            }

            order += $" {AmountofSugar} sugar {TypeofToppings} {TypeofTea}" + "\r\n" +
                $"Total Balance:\t{Balance:C}" + "\r\n" +
                $"Order Date:\t{OrderDateTime}" + "\r\n" +
                $"Take Out?:\t"; // "\r\n" = add a line break, "\t" = add a space. "t" stands for 'tab'

            if (IsTakeout == true)
            {
                order += "Yes";
            }
            else
            {
                order += "No";
            }

            return order;
        }
        #endregion
    }
}
