using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosFunction
{
    class ItemModel
    {
        public string ItemName { get; set; }
        public ItemType ItemType { get; set; }
        public int Quantity { get; set; }
        public string Personalisations { get; set; }

    }
}
