namespace Chatroom.Models.ViewModels
{
    public class ChatroomViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NiceName { get; set; }
        public string Password { get; set; }
        public int MaxMembers { get; set; }
        public string ProfilePicture { get; set; }
        public int Administrator { get; set; }
    }
}