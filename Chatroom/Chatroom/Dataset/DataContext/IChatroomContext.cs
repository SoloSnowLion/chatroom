using Chatroom.Models.ViewModels;

namespace Chatroom.Dataset.DataContext
{
    public interface IChatroomContext
    {
        public ChatroomViewModel GetById(long roomId);
    }
}