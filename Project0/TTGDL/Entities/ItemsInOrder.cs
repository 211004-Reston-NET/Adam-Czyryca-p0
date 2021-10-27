using System;
using System.Collections.Generic;

#nullable disable

namespace TTGDL.Entities
{
    public partial class ItemsInOrder
    {
        public int? OrderId { get; set; }
        public int? LineItemId { get; set; }

        public virtual LineItem LineItem { get; set; }
        public virtual Order Order { get; set; }
    }
}
