using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
   public class Order
    {
        public string OrderID { get; set; }
        public List<string> LineItems { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Customer Customer { get; set; }

        public Order()
        {

        }

        public Order(
            string orderID,
            List<string> lineItems,
            DateTime purchaseDate)
        {
            OrderID = orderID;
            LineItems = lineItems;
            PurchaseDate = purchaseDate;
        }
    }


}
