using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryTracking.Models
{
   
        public class InventoryItem
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public string CreatedOn { get; set; }
        }
    
}