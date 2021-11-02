﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TTGDL.Entities
{
    public partial class LineItem
    {
        public LineItem()
        {
            ItemsInOrders = new HashSet<ItemsInOrder>();
        }

        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Product { get; set; }
        public int Store { get; set; }

        public virtual Product ProductNavigation { get; set; }
        public virtual Store StoreNavigation { get; set; }
        public virtual ICollection<ItemsInOrder> ItemsInOrders { get; set; }
    }
}
