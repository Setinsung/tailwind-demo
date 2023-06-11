using Microsoft.AspNetCore.Mvc;
using MyBBS.BLL;
using MyBBS.Models;

namespace MyBBS.API.Controllers;

[Route("api/[controller]")]
// [Route("[controller]/[action]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserBll _userBll;
    public UserController(IUserBll userBll)
    {
        this._userBll = userBll;
    }
    [HttpGet]
    public List<Users> GetAll()
    {
        List<Users> users = _userBll.GetAll();
        return users;
    }

    [HttpGet("{userNo}/{password}")]
    public Users? GetLoginRes(string userNo, string password)
    {
        Users? user = _userBll.CheckLogin(userNo, password);
        return user;
    }

    [HttpPost]
    public string Insert(string userNo, string userName, int userLevel, string password)
    {
        return _userBll.AddUser(userNo, userName, userLevel, password);
    }

    [HttpPut]
    public string Update(int id, string? userNo, int? userLevel, string? userName, string? password)
    {
        return _userBll.UpdateUser(id, userNo, userLevel, userName, password);
    }

    [HttpDelete]
    public string Delete(int id)
    {
        return _userBll.RemoveUser(id);
    }
}

