using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatroom.Models
{
    public class Chatroom
    {
        private int _id;
        private string _name;
        private string _friendlyName;
        private int _admin;
        private List<int> _memberList;
        private string _picture;

        public Chatroom(int givenId, string givenName, string givenFn, int givenAdmin, List<int> givenMembers,
            string givenImage)
        {
            this._id = givenId;
            this._name = givenName;
            this._friendlyName = givenFn;
            this._admin = givenAdmin;
            this._memberList = givenMembers;
            this._picture = givenImage;
        }

        public bool CheckAccess(int givenUser)
        {
            return _ = (_memberList.Contains(givenUser)) ? true : false;
        }

        public override string ToString()
        {
            return this._name + ", Aantal leden: " + Convert.ToString(_memberList.Count);
        }
    }
}