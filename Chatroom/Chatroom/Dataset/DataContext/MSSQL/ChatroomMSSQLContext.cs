using System.Collections.Generic;
using System.Data;
using Chatroom.Models.ViewModels;

namespace Chatroom.Dataset.DataContext.MSSQL
{
    public class ChatroomMssqlContext : BaseMssqlContext, IChatroomContext
    {
        public ChatroomViewModel GetById(long roomId)
        {
            string SQL = "SELECT * FROM [Chatroom] WHERE ID = @Chatroom_ID";
            List<KeyValuePair<object, object>> parameters = new List<KeyValuePair<object, object>>();
            parameters.Add(new KeyValuePair<object, object>("Chatroom_ID", roomId));

            DataTable dt = ExecuteQuery(SQL, parameters);
            ChatroomViewModel result = DataSetParser.DatasetToChatroom(dt, 0);
            return result;
        }
    }
}