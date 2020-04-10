namespace Chatroom.Models
{
    public class Login
    {
        private string username;
        private string password;
        //private <something> sessionId;

        public bool CheckUsername(string givenUsername)
        {
            //checken of this.username in de DB te vinden is.
            return _ = (givenUsername == "Test") ? true : false;
            //Als username te vinden is, het wachtwoord veld activeren en dat checken
        }

        public bool CheckPassword(string givenPassword)
        {
            //check of this.password in de DB klopt met een hash.
            return _ = (givenPassword == "Wachtwoord") ? true : false;
            //Als wachtwoord klopt voor opgegeven user CreateSession() aanroepen en verder.
        }

        public void CreateSession()
        {
            //Een sessie cookie aanmaken zodat je aangemeld blijft na inloggen.
            
        }

        public void DestroySession()
        {
            //De sessie cookie verwijderen zodat je uitlogt en uitgelogd blijft.
        }
    }
}