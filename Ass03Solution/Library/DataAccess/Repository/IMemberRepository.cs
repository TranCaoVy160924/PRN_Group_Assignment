using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Library
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int memberID);
        Member GetMailAndPassword(string email, string password);
        void InsertMember(Member member);
        void DeleteMember(int memberID);
        void UpdateMember(Member member);
    }
}
