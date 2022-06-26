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
        IEnumerable<MemberDTO> GetMemberObjectByName(string memberobjectName);
        void InsertMember(MemberDTO member);
        void DeleteMember(int memberID);
        void UpdateMember(MemberDTO member);
        MemberDTO GetMemberObjectByEmailAndPassword(string email, string password);
        MemberDTO GetMemberObjectByNameAndID(int memberobjectID, string memberobjectName);
        IEnumerable<MemberDTO> FilterMember(string country, string city);
    }
}
