using System;
using System.Collections.Generic;

namespace Ass2.BusinessObject
{
    public partial class Member
    {
        public Member()
        {
            UserOrders = new HashSet<UserOrder>();
        }

        public int MemberId { get; set; }
        public string Email { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsAdmin { get; set; }

        public virtual ICollection<UserOrder> UserOrders { get; set; }
    }
}
