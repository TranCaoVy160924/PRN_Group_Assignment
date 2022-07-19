using Ass3.Library;

namespace eStore.Models
{
    public class UserOrderViewModel
    {
        public UserOrderViewModel()
        {
        }

        public UserOrderViewModel(UserOrder userOrder)
        {
            this.OrderId = userOrder.OrderId;
            this.MemberId = userOrder.MemberId;
            this.OrderDate = userOrder.OrderDate;
            this.RequiredDate = userOrder.RequiredDate;
            this.ShippedDate = userOrder.ShippedDate;
            this.Freight = userOrder.Freight;
        }

        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }

        public UserOrder ToDBModel()
        {
            return new UserOrder
            {
                OrderId = OrderId,
                MemberId = MemberId,
                OrderDate = OrderDate,
                RequiredDate = RequiredDate,
                ShippedDate = ShippedDate,
                Freight = Freight
            };
        }
    }
}
