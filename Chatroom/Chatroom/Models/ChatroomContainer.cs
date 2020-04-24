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

        private static void FillList()
        {
        }

        private ChatroomContainerViewModel FetchRooms()
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

            foreach (ChatroomViewModel chatView in roomsList.Rooms)
            {
                List<int> members = new List<int>();
                string SQLrooms =
                    "SELECT user_id FROM [Chatroom_User] WHERE chatroom_id = @Chatroom_Id AND access_verified = 1";
                List<KeyValuePair<object, object>> param = new List<KeyValuePair<object, object>>();
                param.Add(new KeyValuePair<object, object>("Chatroom_Id", chatView.Id));
                DataTable dataTable = new BaseMssqlContext().ExecuteQuery(SQLrooms, param);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    members.Add(Convert.ToInt32(dataTable.Rows[i][0]));
                }

                chatView.MemberList = members;
            }

            FillRoomList(roomsList);
            return roomsList;
        }

        private void FillRoomList(ChatroomContainerViewModel rooms)
        {
            foreach (ChatroomViewModel chatView in rooms.Rooms)
            {
                Chatrooms.Add(new Chatroom(chatView.Id, chatView.Name, chatView.NiceName, chatView.Administrator,
                    chatView.MemberList, chatView.ProfilePicture));
            }
        }

        public ChatroomContainerViewModel ListAllChatrooms()
        {
            var result = FetchRooms();


            return result;
        }
    }
}