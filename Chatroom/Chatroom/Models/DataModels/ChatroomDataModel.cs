namespace Chatroom.Models.DataModels
{
    public class ChatroomDataModel
    {
        public int Id { get; }
        public string Name { get; }
        public string NiceName { get; }
        public string Password { get; }
        public int MaxMembers { get; }
        public string ProfilePicture { get; }
        public int Administrator { get; }
        
        public ChatroomDataModel(){}
    }
}