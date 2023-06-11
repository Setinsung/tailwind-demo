using MyBBS.Models;

namespace MyBBS.BLL
{
    public interface IUserBll
    {
        string AddUser(string userNo, string userName, int userLevel, string password);
        Users? CheckLogin(string userNo, string password);
        List<Users> GetAll();
        string RemoveUser(int id);
        string UpdateUser(int id, string? userNo, int? userLevel, string? userName, string? password);
    }

}