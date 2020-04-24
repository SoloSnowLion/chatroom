using System;
using System.Data;
using Chatroom.Models.ViewModels;

namespace Chatroom.Dataset
{
    public class DataSetParser
    {
        public static ChatroomViewModel DatasetToChatroom(DataTable set, int rowIndex)
        {
            return new ChatroomViewModel()
            {
                Id = Convert.ToInt32(set.Rows[rowIndex][0]),
                Name = set.Rows[rowIndex][1].ToString(),
                NiceName = set.Rows[rowIndex][2].ToString(),
                MaxMembers = Convert.ToInt32(set.Rows[rowIndex][4]),
                ProfilePicture = set.Rows[rowIndex][5].ToString(),
                Administrator = Convert.ToInt32(set.Rows[rowIndex][6]),
            };
        }
    }
}