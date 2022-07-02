using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Ass1.BusinessObject;
using System.Data;

namespace Ass1.DataAccess
{
    public class MemberDAO: BaseDAL
    {
        //---------------------------------------------
        //singleton
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
        //---------------------------------------------

        public IEnumerable<MemberDTO> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID, MemberName, Email, " +
                "Password, City, Country " +
                "From FStore";
            var members = new List<MemberDTO>();
            try
            {
                dataReader = dataProvider.ExecuteSqlQuery(SQLSelect,
                    CommandType.Text, out connection);
                SqlDataReader reader = (SqlDataReader) dataReader;
                while (reader.Read())
                {
                    members.Add(new MemberDTO
                    {
                        MemberID = reader.GetInt32("MemberID"),
                        MemberName = reader.GetString("MemberName"),
                        MemberEmail = reader.GetString("Email"),
                        Password = reader.GetString("Password"),
                        MemberCity = reader.GetString("City"),
                        MemberCountry = reader.GetString("Country")
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    CloseConnection();
                }
            }
            return members;
        }

        public MemberDTO GetMemberByID(int MemberID)
        {
            MemberDTO member = null;
            IDataReader dataReader = null;
            String SQLSelect = "Select MemberID, MemberName, Email, " +
                "Password, City, Country " +
                "From FStore " +
                "Where MemberID = @MemberID";
            //string SQLSelect = "SelectCarID, CarName, " +
            //    "Manufacturer, Price, ReleaseYear from Cars" +
            //    "where CarID = @CarID";
            try
            {
                var param = dataProvider.CreateParameter(
                    "@MemberID", 4, MemberID, DbType.Int32);
                dataReader = dataProvider.ExecuteSqlQuery(
                    SQLSelect, CommandType.Text,
                    out connection, param);
                SqlDataReader reader = (SqlDataReader) dataReader;
                if (reader.Read())
                {
                    member = new MemberDTO
                    {
                        MemberID = reader.GetInt32("MemberID"),
                        MemberName = reader.GetString("MemberName"),
                        MemberEmail = reader.GetString("Email"),
                        Password = reader.GetString("Password"),
                        MemberCity = reader.GetString("City"),
                        MemberCountry = reader.GetString("Country")
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    CloseConnection();
                }
            }
            return member;
        }

        public IEnumerable<MemberDTO> GetMemberByName(string memberName)
        {
            var members = new List<MemberDTO>();
            IDataReader dataReader = null;
            String SQLSelect = "Select MemberID, MemberName, Email, " +
                "Password, City, Country " +
                "From FStore " +
                "Where MemberName like @MemberName";
            try
            {
                var param = dataProvider.CreateParameter(
                    "@MemberName", 50, '%' + memberName + '%', DbType.String);
                dataReader = dataProvider.ExecuteSqlQuery(
                    SQLSelect, CommandType.Text,
                    out connection, param);
                SqlDataReader reader = (SqlDataReader)dataReader;
                while (reader.Read())
                {
                    members.Add(new MemberDTO
                    {
                        MemberID = reader.GetInt32("MemberID"),
                        MemberName = reader.GetString("MemberName"),
                        MemberEmail = reader.GetString("Email"),
                        Password = reader.GetString("Password"),
                        MemberCity = reader.GetString("City"),
                        MemberCountry = reader.GetString("Country")
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    CloseConnection();
                }
            }
            return members;
        }

        public MemberDTO CheckLogin(string email, string password)
        {
            MemberDTO member = new MemberDTO();
            IDataReader dataReader = null;
            String SQLSelect = "Select MemberID, MemberName, Email, " +
                "Password, City, Country " +
                "From FStore " +
                "Where Email = @Email and Password = @Password";
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter(
                        "@Email", 100, email, DbType.String));
                parameters.Add(dataProvider.CreateParameter(
                    "@Password", 30, password, DbType.String));

                dataReader = dataProvider.ExecuteSqlQuery(
                    SQLSelect, CommandType.Text,
                    out connection, parameters.ToArray());
                SqlDataReader reader = (SqlDataReader)dataReader;
                if (reader.Read())
                {
                    member = new MemberDTO
                    {
                        MemberID = reader.GetInt32("MemberID"),
                        MemberName = reader.GetString("MemberName"),
                        MemberEmail = reader.GetString("Email"),
                        Password = reader.GetString("Password"),
                        MemberCity = reader.GetString("City"),
                        MemberCountry = reader.GetString("Country")
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    CloseConnection();
                }
            }
            return member;
        }
        //--------------------------------------------
        public void AddMember(MemberDTO member)
        {
            try
            {
                //check if exist already
                MemberDTO newMember = GetMemberByID(member.MemberID);
                if (newMember == null)
                {
                    string SQLInsert = "Insert FStore (MemberName, Email, " +
                        "Password, City, Country " +
                        ") values ( " +
                        "@MemberName, @Email, @Password, " +
                        "@City, @Country)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter(
                        "@MemberName", 50, member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter(
                        "@Email", 100, member.MemberEmail,  DbType.String));
                    parameters.Add(dataProvider.CreateParameter(
                        "@Password", 30, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter(
                        "@City", 15, member.MemberCity, DbType.String));
                    parameters.Add(dataProvider.CreateParameter(
                        "@Country", 15, member.MemberCountry, DbType.String));
                    dataProvider.ExecuteSqlUpdate(SQLInsert, CommandType.Text,
                        parameters.ToArray());
                }
                else
                {
                    throw new Exception("The car is already exist");
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
        //--------------------------------------------
        public void UpdateMember(MemberDTO member)
        {
            try
            {
                MemberDTO updatingMember = GetMemberByID(member.MemberID);
                if (updatingMember != null)
                {
                    string SQLInsert = "Update FStore " +
                        "Set MemberName = @MemberName, " +
                        "Email = @Email, Password = @Password, " +
                        "City = @City, Country = @Country " +
                        "Where MemberID = @MemberID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter(
                        "@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter(
                        "@MemberName", 50, member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter(
                        "@Email", 100, member.MemberEmail, DbType.String));
                    parameters.Add(dataProvider.CreateParameter(
                        "@Password", 30, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter(
                        "@City", 15, member.MemberCity, DbType.String));
                    parameters.Add(dataProvider.CreateParameter(
                        "@Country", 15, member.MemberCountry, DbType.String));
                    dataProvider.ExecuteSqlUpdate(SQLInsert, CommandType.Text,
                        parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member does not already exist");
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
        //--------------------------------------------
        public void RemoveMember(int memberID)
        {
            try
            {
                MemberDTO removingMember = GetMemberByID(memberID);
                if (removingMember != null)
                {
                    string SQLDelete = "Delete FStore " +
                        "where MemberID = @MemberID";
                    var param = dataProvider.CreateParameter(
                        "@MemberID", 4, memberID, DbType.Int32);
                    dataProvider.ExecuteSqlUpdate(SQLDelete,
                        CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The member does not already exist");
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
        //----------------------------------------------------------------
        public IEnumerable<MemberDTO> FilterMember(string country, string city)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID, MemberName, Email, " +
                "Password, City, Country " +
                "From FStore " +
                "Where City like '" + city + "' and " +
                "Country like '" + country + "'";
            var members = new List<MemberDTO>();
            try
            {
                dataReader = dataProvider.ExecuteSqlQuery(SQLSelect,
                    CommandType.Text, out connection);
                SqlDataReader reader = (SqlDataReader)dataReader;
                while (reader.Read())
                {
                    members.Add(new MemberDTO
                    {
                        MemberID = reader.GetInt32("MemberID"),
                        MemberName = reader.GetString("MemberName"),
                        MemberEmail = reader.GetString("Email"),
                        Password = reader.GetString("Password"),
                        MemberCity = reader.GetString("City"),
                        MemberCountry = reader.GetString("Country")
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                    CloseConnection();
                }
            }
            return members;
        }
    }
}
    

