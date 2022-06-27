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
            var members = dBContext.Members.ToList();
            return members;
        }

        public Member GetMemberByID(int MemberID)
        {
            IEnumerable<Member> members = dBContext.Members.Where(mem => mem.MemberId == MemberID);
            Member member = members.FirstOrDefault();
            return member;
        }

        public Member GetMailAndPassword(string Email, string Password)
        {
            Member member = dBContext.Members.Where(mem => mem.Email == Email && mem.Password == Password).FirstOrDefault();
            return member;
        }

        //delete a member
        public void Delete(int MemberID)
        {
            try
            {
                var member = dBContext.Members.SingleOrDefault(mem => mem.MemberId == MemberID);
                if (member != null)
                {
                    dBContext.Members.Remove(member);
                    dBContext.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        //add a member
        public void Add(Member m)
        {
            try
            {
                dBContext.Members.Add(m);
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        //update a member
        public void Update(Member m)
        {
            try
            {
                var member = dBContext.Members.SingleOrDefault(mem => mem.MemberId == m.MemberId);
                if (member != null)
                {
                    dBContext.Members.Update(member);
                    dBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}