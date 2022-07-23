using Ass3.Library;

namespace eStore.Models
{
    public static class DBHelper
    {
        public static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:BankAccountTypeDB"];
            return strConn;
        }

        public static void GetDefaultAccount()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            string userID = config["DefaulAccount:USERNAME"];
            string password = config["DefaulAccount:PASSWORD"];

            MemberRepository memberRepository = new MemberRepository();
            Member preExister = memberRepository.GetMailAndPassword(userID, password);  
            if (preExister == null)
            {
                Member member = new Member
                {
                    Email = userID,
                    Password = password,
                    City = "",
                    Country = "",
                    CompanyName = "",
                    IsAdmin = true
                };

                memberRepository.InsertMember(member);
            }
        }
    }
}
