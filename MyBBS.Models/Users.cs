namespace MyBBS.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string? UserNo { get; set; }
        public string? UserName { get; set; }
        public int? UserLevel { get; set; }
        public string? Password { get; set; }
        public bool isDeleted { get; set; }
    }
}