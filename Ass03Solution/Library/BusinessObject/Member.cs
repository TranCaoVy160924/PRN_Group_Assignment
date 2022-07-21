using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ass3.Library 
{   [Serializable]
    public partial class Member: ISerializable
    {
        public Member()
        {
            UserOrders = new HashSet<UserOrder>();
        }

        public Member(SerializationInfo info, StreamingContext ctxt)
        {
            this.MemberId = info.GetInt32("MemberId");
            this.Email = info.GetString("Email");
            this.CompanyName = info.GetString("CompanyName");
            this.City = info.GetString("City");
            this.Country = info.GetString("Country");
            this.Password = info.GetString("Password");
            this.IsAdmin = info.GetBoolean("IsAdmin");
            this.UserOrders = (ICollection<UserOrder>?)info
                .GetValue("UserOrders", typeof(ICollection<UserOrder>));
        }

        public int MemberId { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public virtual ICollection<UserOrder> UserOrders { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
            info.AddValue("MemberId", MemberId);
            info.AddValue("Email", Email);
            info.AddValue("CompanyName", CompanyName);
            info.AddValue("City", City);
            info.AddValue("Country", Country);
            info.AddValue("Password", Password);
            info.AddValue("IsAdmin", IsAdmin);
            info.AddValue("UserOrders", UserOrders);
        }
    }
}
