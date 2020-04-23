using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Chatroom.Dataset;

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

        private static int FetchRooms()
        {
            string SQL = "SELECT * FROM [Chatroom]";
            List<KeyValuePair<object, object>> parameters = new List<KeyValuePair<object, object>>();

            // DataTable dt = ExecuteQuery(SQL);
            DataTable dt = new BaseMssqlContext().ExecuteQuery(SQL, parameters);

            return dt.Columns.Count;
        }

        public void ListAllChatrooms()
        {
            var result = FetchRooms();
            // foreach (var VARIABLE in Chatrooms)
            // {
            //     //display chatrooms in list
            // }
        }
    }
}