﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TTGDL.Entities
{
    public partial class ItemsInOrder
    {
        public int OrderId { get; set; }
        public int LineItemId { get; set; }
        public int Id { get; set; }
        public int Quantity { get; set; }

        public virtual LineItem LineItem { get; set; }
        public virtual Order Order { get; set; }
    }
}
