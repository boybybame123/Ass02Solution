using BusinessObject;
using DataAccess.Access;
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
                }
                return instance;
            }
        }

        public IEnumerable<Member> GetMemberList()
        {
            IDataReader dataReader = null;
            var memberList = new List<Member>();
            string SQLSelect = "select MemberId, Email, CompanyName, City, Country, Password from Member";
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    memberList.Add(new Member
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5),
                    });
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
            return memberList;
        }
        public Member GetMemberById(int memberId)
        {
            Member member = null;
            IDataReader dataReader = null;
            string SQLSelect = "select MemberId, Email, CompanyName, City, Country, Password" +
                " from Member where MemberId = @MemberId";
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new Member
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5),
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
        public void AddNew(Member member)
        { 
            try
            {
                Member mem = GetMemberById(member.MemberId);
                if (mem == null)
                {
                    string SQLInsert = "insert Member values(@MemberId,@Email,@CompanyName,@City,@Country,@Password)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 50, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Country, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Member is already exist.");
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
        public void Update(Member member)
        {
            try
            {
                Member mem = GetMemberById(member.MemberId);
                if (mem != null)
                {
                    string SQLUpdate = "Update Member set MemberId = @MemberId,Email = @Email,CompanyName = @CompanyName " +
                        "City = @City,Country = @Country,Password = @Password where MemberId = @MemberId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 50, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Country, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Member does not exist.");
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
        public void Remove(int memberId)
        {
            try
            {
                Member mem = GetMemberById(memberId);
                if (mem != null)
                {
                    string SQLDelete = "Delete Member where MemberId = @MemberId";
                    var parameters = dataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, parameters);
                }
                else
                {
                    throw new Exception("Member does not exist.");
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
