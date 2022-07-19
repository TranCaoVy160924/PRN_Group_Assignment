using System;
using System.Collections.Generic;

namespace Ass3.Library 
{ 
    public partial class Member
    {
        public Member()
        {
            UserOrders = new HashSet<UserOrder>();
        }

        public int MemberId { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public virtual ICollection<UserOrder> UserOrders { get; set; }
    }
}
