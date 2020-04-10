using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chatroom.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Name { get; private set; }
        public string Status { get; private set; }
        public string Email { get; private set; }
        public string ProfilePicture { get; private set; }
        private bool verified;

        public User(int TheId)
        {
            this.Id = TheId;
        }

        public void LoadUserData()
        {
            //Methode om gegevens uit de database te halen.
        }

        public string LoadSettings()
        {
            return "De instellingen voor gebruiker " + this.Username + " zijn geladen en klaar voor gebruik.";
        }

        public void UpdateUsername(string newUsername)
        {
            this.Username = newUsername;
        }

        public void UpdateName(string newName)
        {
            this.Name = newName;
        }

        public void UpdateStatus(string newStatus)
        {
            this.Status = newStatus;
        }

        public void UpdateEmail(string newEmail)
        {
            this.Email = newEmail;
        }

        public void UpdateProfilePicture(string newProfilePicture)
        {
            this.ProfilePicture = newProfilePicture;
        }

        public void UpdateVerified(bool newVerified)
        {
            this.verified = newVerified;
        }
    }
}
