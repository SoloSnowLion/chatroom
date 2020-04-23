using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Chatroom.Dataset;
using Chatroom.Models.ViewModels;

namespace Chatroom.Models
{
    public class ChatroomContainer
    {
        public List<Chatroom> Chatrooms = new List<Chatroom>();
        private int _currentUser;

        public ChatroomContainer(int givenUser)
        {
            this._currentUser = givenUser;
        }

        private static ChatroomContainerViewModel FetchRooms()
        {
            ChatroomContainerViewModel roomsList = new ChatroomContainerViewModel();
            string SQL = "SELECT * FROM [Chatroom]";
            List<KeyValuePair<object, object>> parameters = new List<KeyValuePair<object, object>>();
            DataTable dt = new BaseMssqlContext().ExecuteQuery(SQL, parameters);
            roomsList.Rooms = new List<ChatroomViewModel>();
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                roomsList.Rooms.Add(DataSetParser.DatasetToChatroom(dt, j));
            }
            ChatroomViewModel result = DataSetParser.DatasetToChatroom(dt, 0);
            return roomsList;
        }

        public ChatroomContainerViewModel ListAllChatrooms()
        {
            var result = FetchRooms();
            return result;
        }
    }
}