using System.Data;
using Microsoft.Data.SqlClient;
using MyBBS.DAL.Core;
using MyBBS.Models;

namespace MyBBS.DAL
{
    public class UserDal
    {
        public List<Users> GetAll()
        {
            DataTable res = SqlHelper.ExecuteTable("Select * from Users");
            List<Users> userList = ToModelList(res);
            return userList;
        }
        public List<Users> GetUserByUNoAndPwd(string userNo, string password)
        {
            DataTable res = SqlHelper.ExecuteTable(
                "Select * from Users where UserNo=@UserNo and Password=@Password",
                new SqlParameter("@UserNo", userNo),
                new SqlParameter("@Password", password)
            );
            List<Users> userList = ToModelList(res);
            return userList;
        }

        public Users GetUserById(int id)
        {
            DataTable res = SqlHelper.ExecuteTable("Select * from Users where Id=@Id", new SqlParameter("@Id", id));
            DataRow dr = res.Rows[0];
            Users user = ToModel(dr);
            return user;
        }

        public int AddUser(string userNo, string userName, int userLevel, string password)
        {
            return SqlHelper.ExecuteNonQuery(
                "insert into Users(UserNo,UserName,UserLevel,Password) values(@UserNo,@UserName,@UserLevel,@Password)",
                new SqlParameter("@UserNo", userNo),
                new SqlParameter("@UserName", userName),
                new SqlParameter("@UserLevel", userLevel),
                new SqlParameter("@Password", password)
            );
        }

        public int UpdateUser(int id, string? userNo, int? userLevel, string? userName, string? password)
        {
            DataTable res = SqlHelper.ExecuteTable("Select * from Users Where Id = @Id", new SqlParameter("@Id", id));
            if (res.Rows.Count == 0) return 0;
            DataRow dr = res.Rows[0];

            Users user = new Users();
            user.Id = (int)dr["Id"];
            user.UserNo = userNo ?? dr["UserNo"].ToString();
            user.UserName = userName ?? dr["UserName"].ToString();
            user.UserLevel = userLevel ?? (int)dr["UserLevel"];
            user.Password = password ?? dr["Password"].ToString();

            return SqlHelper.ExecuteNonQuery(
                "update Users set UserNo=@UserNo,userName=@userName,userLevel=@userLevel,password=@password where Id=@Id",
                new SqlParameter("@UserNo", user.UserNo),
                new SqlParameter("@UserName", user.UserName),
                new SqlParameter("@UserLevel", user.UserLevel),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@Id", user.Id)
            );
        }

        public int RemoveUser(int id)
        {
            return SqlHelper.ExecuteNonQuery(
                "delete from Users where Id=@Id",
                new SqlParameter("@Id", id)
            );
        }

        private List<Users> ToModelList(DataTable table)
        {
            List<Users> userList = new();
            for (var i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                userList.Add(ToModel(row));
            }
            return userList;
        }

        private Users ToModel(DataRow dr)
        {
            Users user = new Users()
            {
                Id = (int)dr["Id"],
                UserNo = dr["UserNo"].ToString(),
                UserName = dr["UserName"].ToString(),
                UserLevel = (int)dr["UserLevel"],
                Password = dr["Password"].ToString(),
                isDeleted = (bool)dr["IsDelete"]
            };
            return user;
        }
    }

}