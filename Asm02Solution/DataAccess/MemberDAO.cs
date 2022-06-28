using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
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
        //------------------------------------

        public IEnumerable<MemberObject> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID ,Email ,CompanyName, Country,City, Password from Member  ";
            var members = new List<MemberObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberEmail = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        MemberCountry = dataReader.GetString(3),
                        MemberCity = dataReader.GetString(4),
                        MemberPassword = dataReader.GetString(5),

                    }
                        );
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }
        //-------------------------------------------------------------------------
        public MemberObject GetMemberByID(int memberID)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID ,Email ,CompanyName, Country,City, Password from Member Where MemberID=@MemberID";
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberEmail = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        MemberCountry = dataReader.GetString(3),
                        MemberCity = dataReader.GetString(4),
                        MemberPassword = dataReader.GetString(5),
                    };
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;

        }
        public void AddNew(MemberObject member)
        {
            try
            {
                MemberObject m = GetMemberByID(member.MemberID);
                if (m == null)
                {
                    string SQLInsert = " Insert Member Values (@MemberID,@Email,@CompanyName,@City,@Country,@Password)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.MemberEmail, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 50, member.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, member.MemberCity, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, member.MemberCountry, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.MemberPassword, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());

                }
                else
                {
                    throw new Exception("This Member is existed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(MemberObject member)
        {
            try
            {
                MemberObject m = GetMemberByID(member.MemberID);
                if (m != null)
                {

                    string SQLUpdate = "Update Major set Email=@Email , CompanyName=@CompanyName , City=@City , Country=@Country , Password=@Password where MemberID=@MemberID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.MemberEmail, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 50, member.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, member.MemberCity, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, member.MemberCountry, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.MemberPassword, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());

                }
                else
                {
                    throw new Exception("This member does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Remove(int memberID)
        {
            try
            {
                MemberObject m = GetMemberByID(memberID);
                if (m != null)
                {
                    string SQLDelete = " Delete Member where MemberID=@MemberID ";
                    var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The car does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}