using System;
using System.Collections.Generic;

#nullable disable

namespace TTGDL.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public int StoreFront { get; set; }
        public int Customer { get; set; }
        public double Total { get; set; }

        public virtual Customer CustomerNavigation { get; set; }
        public virtual Store StoreFrontNavigation { get; set; }
    }
}
