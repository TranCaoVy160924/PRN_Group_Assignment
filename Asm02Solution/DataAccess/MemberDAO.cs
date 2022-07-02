using Ass2.BusinessObject;

namespace Ass2.DataAccess
{
    public class MemberDAO
    {
        //---------------------------------------------
        //singleton
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        ASS2_DBContext dBContext = new ASS2_DBContext();

        private MemberDAO() { }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        //---------------------------------------------

        public IEnumerable<Member> GetMemberList()
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            var members = dBContext.Members.ToList();
            return members;
        }

        public Member GetMemberByID(int MemberID)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            IEnumerable<Member> members = dBContext.Members.Where(mem => mem.MemberId == MemberID);
            Member member = members.FirstOrDefault();
            return member;
        }

        public Member GetMailAndPassword(string Email, string Password)
        {
            using ASS2_DBContext dBContext = new ASS2_DBContext();
            Member member = dBContext.Members.Where(mem => mem.Email == Email && mem.Password == Password).FirstOrDefault();
            return member;
        }

        //delete a member
        public void Delete(int MemberID)
        {
            try
            {
                using ASS2_DBContext dBContext = new ASS2_DBContext();

                var member = dBContext.Members.SingleOrDefault(mem => mem.MemberId == MemberID);
                if (member != null)
                {
                    dBContext.Remove(member);
                    dBContext.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            
        }

        //add a member
        public void Add(Member m)
        {
            try
            {
                using ASS2_DBContext dBContext = new ASS2_DBContext();
                dBContext.Members.Add(m);
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        //update a member
        public void Update(Member member)
        {
            try
            {
                using ASS2_DBContext dBContext = new ASS2_DBContext();
                //var member = dBContext.Members.SingleOrDefault(mem => mem.MemberId == m.MemberId);
                dBContext.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dBContext.SaveChanges();
                //if (member != null)
                //{
                //    dBContext.Members.Update(member);
                //    dBContext.SaveChanges();
                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}