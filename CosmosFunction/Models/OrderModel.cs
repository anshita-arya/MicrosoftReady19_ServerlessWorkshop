using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosFunction
{
    class OrderModel
    {
        public string CustomerName { get; set; }
        public string CustomerContactNumber { get; set; }
        public string BaristaId { get; set; }

        public IList<ItemModel> OrderItems { get; set; }
        
    }
}
