using System;
using System.Collections.Generic;

namespace Ass3.Library
{
    public partial class UserOrder
    {
        public UserOrder()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }

        public virtual Member Member { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
