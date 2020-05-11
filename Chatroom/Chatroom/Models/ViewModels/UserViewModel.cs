using System.Collections.Generic;

namespace Chatroom.Models.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public bool Verified;
    }
}