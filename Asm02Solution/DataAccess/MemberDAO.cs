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
<<<<<<< Updated upstream
            IEnumerable<Member> members = dBContext.Members.Where(mem => mem.MemberId == MemberID);
            Member member = members.FirstOrDefault();
            return member;
        }

        public Member GetMemberByMailAndPassword(string Email, String Password)
        {
            Member member = dBContext.Members.Where(mem =>mem.Email == Email && mem.Password == Password).FirstOrDefault();
=======
<<<<<<< HEAD
            Member member = dBContext.Members.Where(mem => mem.MemberId == MemberID).FirstOrDefault();
=======
            IEnumerable<Member> members = dBContext.Members.Where(mem => mem.MemberId == MemberID);
            Member member = members.FirstOrDefault();
>>>>>>> Stashed changes
            return member;
        }

        public Member GetMemberByMailAndPassword(string Email, String Password)
        {
            Member member = dBContext.Members.Where(mem =>mem.Email == Email && mem.Password == Password).FirstOrDefault();
>>>>>>> 839117a665427bc6e57c683bc949283ffb035b2c
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
        //--------------------------------------------
        //public void AddMember(MemberDTO member)
        //{
        //    try
        //    {
        //        //check if exist already
        //        MemberDTO newMember = GetMemberByID(member.MemberID);
        //        if (newMember == null)
        //        {
        //            string SQLInsert = "Insert FStore (MemberName, Email, " +
        //                "Password, City, Country " +
        //                ") values ( " +
        //                "@MemberName, @Email, @Password, " +
        //                "@City, @Country)";
        //            var parameters = new List<SqlParameter>();
        //            parameters.Add(dataProvider.CreateParameter(
        //                "@MemberName", 50, member.MemberName, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter(
        //                "@Email", 100, member.MemberEmail, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter(
        //                "@Password", 30, member.Password, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter(
        //                "@City", 15, member.MemberCity, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter(
        //                "@Country", 15, member.MemberCountry, DbType.String));
        //            dataProvider.ExecuteSqlUpdate(SQLInsert, CommandType.Text,
        //                parameters.ToArray());
        //        }
        //        else
        //        {
        //            throw new Exception("The car is already exist");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}
        ////--------------------------------------------
        //public void UpdateMember(MemberDTO member)
        //{
        //    try
        //    {
        //        MemberDTO updatingMember = GetMemberByID(member.MemberID);
        //        if (updatingMember != null)
        //        {
        //            string SQLInsert = "Update FStore " +
        //                "Set MemberName = @MemberName, " +
        //                "Email = @Email, Password = @Password, " +
        //                "City = @City, Country = @Country " +
        //                "Where MemberID = @MemberID";
        //            var parameters = new List<SqlParameter>();
        //            parameters.Add(dataProvider.CreateParameter(
        //                "@MemberID", 4, member.MemberID, DbType.Int32));
        //            parameters.Add(dataProvider.CreateParameter(
        //                "@MemberName", 50, member.MemberName, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter(
        //                "@Email", 100, member.MemberEmail, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter(
        //                "@Password", 30, member.Password, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter(
        //                "@City", 15, member.MemberCity, DbType.String));
        //            parameters.Add(dataProvider.CreateParameter(
        //                "@Country", 15, member.MemberCountry, DbType.String));
        //            dataProvider.ExecuteSqlUpdate(SQLInsert, CommandType.Text,
        //                parameters.ToArray());
        //        }
        //        else
        //        {
        //            throw new Exception("The member does not already exist");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}
        ////--------------------------------------------
        //public void RemoveMember(int memberID)
        //{
        //    try
        //    {
        //        MemberDTO removingMember = GetMemberByID(memberID);
        //        if (removingMember != null)
        //        {
        //            string SQLDelete = "Delete FStore " +
        //                "where MemberID = @MemberID";
        //            var param = dataProvider.CreateParameter(
        //                "@MemberID", 4, memberID, DbType.Int32);
        //            dataProvider.ExecuteSqlUpdate(SQLDelete,
        //                CommandType.Text, param);
        //        }
        //        else
        //        {
        //            throw new Exception("The member does not already exist");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}
    }
}