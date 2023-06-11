using MyBBS.Models;
using MyBBS.DAL;
namespace MyBBS.BLL
{
    public class UserBll : IUserBll
    {
        UserDal userDal = new();
        public Users? CheckLogin(string userNo, string password)
        {
            List<Users> userlist = userDal.GetUserByUNoAndPwd(userNo, password);
            if (userlist.Count <= 0)
            {
                return default;
            }
            else
            {
                Users? user = userlist.Find(m => !m.isDeleted);
                return user;
            }
        }

        public List<Users> GetAll()
        {
            return userDal.GetAll().FindAll(m => !m.isDeleted);
        }

        public string AddUser(string userNo, string userName, int userLevel, string password)
        {
            int rows = userDal.AddUser(userNo, userName, userLevel, password);
            if (rows > 0) return "数据插入成功";
            return "数据插入失败";
        }

        public string UpdateUser(int id, string? userNo, int? userLevel, string? userName, string? password)
        {
            int rows = userDal.UpdateUser(id, userNo, userLevel, userName, password);
            if (rows > 0) return "数据修改成功";
            return "数据修改失败";
        }

        public string RemoveUser(int id)
        {
            int rows = userDal.RemoveUser(id);
            if (rows > 0) return "数据删除成功";
            return "数据删除失败";
        }
    }

}