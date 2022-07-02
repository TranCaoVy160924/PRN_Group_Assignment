using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass1.BusinessObject;
using Ass1.DataAccess;

namespace Ass1.DataAccess
{
    public class MemberRepository: IMemberRepository
    {
        public IEnumerable<MemberDTO> GetMembers()
            => MemberDAO.Instance.GetMemberList();

        public MemberDTO GetMemberByID(int memberID) 
            => MemberDAO.Instance.GetMemberByID(memberID);
        public void InsertMember(MemberDTO member)
            => MemberDAO.Instance.AddMember(member);
        public void DeleteMember(int memberID)
            => MemberDAO.Instance.RemoveMember(memberID);
        public void UpdateMember(MemberDTO member) 
            => MemberDAO.Instance.UpdateMember(member);
        public IEnumerable<MemberDTO> FilterMember(string country, string city)
            => MemberDAO.Instance.FilterMember(country, city);

        public MemberDTO GetMemberObjectByEmailAndPassword(string email, string password)
            => MemberDAO.Instance.CheckLogin(email, password);


        public IEnumerable<MemberDTO> GetMemberObjectByName(string memberobjectName)
            => MemberDAO.Instance.GetMemberByName(memberobjectName);
        

        public MemberDTO GetMemberObjectByNameAndID(int memberobjectID, string memberobjectName)
        {
            throw new NotImplementedException();
        }
    }
}

