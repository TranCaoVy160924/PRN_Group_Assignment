using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass2.BusinessObject;

namespace Ass2.DataAccess.Repository
{
    public class MemberRepository
    {
        public IEnumerable<Member> GetMembers()
            => MemberDAO.Instance.GetMemberList();
    }
}
