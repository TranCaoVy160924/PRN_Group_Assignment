using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass2.BusinessObject;

namespace Ass2.DataAccess.Repository
{
    public class MemberRepository: IMemberRepository
    {
        public IEnumerable<Member> GetMembers()
            => MemberDAO.Instance.GetMemberList();

        public Member GetMemberByID(int memberID)
        {
            return MemberDAO.Instance.GetMemberByID(memberID);
        }

        public Member GetMailAndPassword(string email, string password)
        {
            return MemberDAO.Instance.GetMailAndPassword(email, password);
        }
        public void InsertMember(Member member)
        {

        }

        public void DeleteMember(int memberID) 
           => MemberDAO.Instance.Delete(memberID);
        
        public void UpdateMember(Member member)
        {

        }
    }
}
