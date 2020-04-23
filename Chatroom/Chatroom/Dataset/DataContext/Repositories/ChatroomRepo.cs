using Chatroom.Models.ViewModels;

namespace Chatroom.Dataset.DataContext.Repositories
{
    public class ChatroomRepo : IChatroomContext
    {
        private IChatroomContext _context;

        public ChatroomRepo(IChatroomContext context)
        {
            this._context = context;
        }

        public ChatroomViewModel GetById(long roomId)
        {
            return _context.GetById(roomId);
        }
    }
}