using System;
using System.Collections.Generic;

namespace TTGModel
{
    public partial class ItemsInOrder
    {
        public int OrderId { get; set; }
        public int LineItemId { get; set; }
        public int Id { get; set; }
        public int Quantity { get; set; }

        public LineItem LineItem { get; set; }
        public Orders Order { get; set; }
    }
}
