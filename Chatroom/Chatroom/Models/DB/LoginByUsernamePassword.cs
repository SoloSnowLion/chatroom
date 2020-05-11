namespace Chatroom.Models.DB
{
    public partial class LoginByUsernamePassword
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}