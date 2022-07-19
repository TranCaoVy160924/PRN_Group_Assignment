using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Library
{
    public class MemberRepository : IMemberRepository
    {
        private string ConnectionString;

        public MemberRepository()
        {
        }

        public IEnumerable<Member> GetMembers()
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();

            var members = dBContext.Members.ToList();

            return members;
        }

        public Member GetMemberByID(int memberID)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();

            IEnumerable<Member> members = dBContext.Members.Where(mem => mem.MemberId == memberID);
            Member? member = members.FirstOrDefault();

            return member;
        }

        public Member GetMailAndPassword(string email, string password)
        {
            using ASS2_DBContext dBContext
                = new ASS2_DBContext();
            Member? member = dBContext.Members.Where(
                mem => mem.Email == email && mem.Password == password).FirstOrDefault();

            return member;
        }

        public void InsertMember(Member member)
        {
            using ASS2_DBContext dBContext
                    = new ASS2_DBContext();
            try
            {
                dBContext.Members.Add(member);
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteMember(int memberID)
        {
            using ASS2_DBContext dBContext
                    = new ASS2_DBContext();
            try
            {
                Member? member = dBContext.Members.Where(
                    mem => mem.MemberId == memberID).FirstOrDefault();
                if (member != null)
                {
                    dBContext.Members.Remove(member);
                    dBContext.SaveChanges();
                }
                else
                {
                    throw new Exception("The member is not already existed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateMember(Member member)
        {
            using ASS2_DBContext dBContext
                    = new ASS2_DBContext();
            try
            {
                dBContext.Entry<Member>(member).State
                    = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
