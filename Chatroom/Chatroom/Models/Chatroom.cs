using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatroom.Models
{
    public class Chatroom
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string FriendlyName { get; private set; }
        public int Admin { get; private set; }
        public List<int> MemberList { get; private set; }
        public string Picture { get; private set; }
        public int MaxMembers { get; private set; }

        public Chatroom(int givenId, string givenName, string givenFn, int givenAdmin, List<int> givenMembers,
            string givenImage, int givenMaxMembers)
        {
            this.Id = givenId;
            this.Name = givenName;
            this.FriendlyName = givenFn;
            this.Admin = givenAdmin;
            this.MemberList = givenMembers;
            this.Picture = givenImage;
            this.MaxMembers = givenMaxMembers;
        }

        public int GetId()
        {
            return Id;
        }

        public bool CheckAccess(int givenUser)
        {
            return _ = (MemberList.Contains(givenUser)) ? true : false;
        }

        public override string ToString()
        {
            return this.Name + ", Aantal leden: " + Convert.ToString(MemberList.Count);
        }
    }
}