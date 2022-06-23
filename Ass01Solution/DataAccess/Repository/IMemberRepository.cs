using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass1.BusinessObject;

namespace Ass1.DataAccess
{
    public interface IMemberRepository
    {
        IEnumerable<MemberDTO> GetMembers();
        MemberDTO GetMemberByID(int memberID);
        void InsertMember(MemberDTO member);
        void DeleteMember(int memberID);
        void UpdateMember(MemberDTO member);
    }
}
