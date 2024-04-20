using PersonalInformationModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace PersonalInformationDataServices
{
    public class UserDataService
    {
        private List<User> dummyUsers = new List<User>();

        public UserDataService()
        {
            UserInformations();
        }

        private void UserInformations()
        {
            dummyUsers.Add(new User
            {
                userName = "joyceguigayoma",
                password = "joyce123",
                fullName = "Joyce Anne R. Guigayoma",
                course = "Bachelor of Science in Information Technology",
                address = "Sto. Tomas Binan Laguna",
                phoneNumber = "09357532166",
                emailAddress = "guigayoma.joyceanne@gmail.com",
                dateOfBirth = "September 30, 2003",
                gender = "Female",
                motto = "God is in control",
            });

            dummyUsers.Add(new User
            {
                userName = "hannaguigayoma",
                password = "hanna123",
                fullName = "Hanna Joy R. Guigayoma",
                course = "Bachelor of Science in Accountancy",
                address = "Sto. Tomas Binan Laguna",
                phoneNumber = "09357532166",
                emailAddress = "guigayomahanna@gmail.com",
                dateOfBirth = "October 7, 2001",
                gender = "Female",
                motto = "Live with gratitude and kindness.",
            });

            dummyUsers.Add(new User
            {
                userName = "friscelrivera",
                password = "friscel123",
                fullName = "Friscel Mark T. Rivera",
                course = "Bachelor of Science in Information Technology",
                address = "Sto. Tomas Binan Laguna",
                phoneNumber = "09679824571",
                emailAddress = "guigayoma.joyceanne@gmail.com",
                dateOfBirth = "September 13, 2004",
                gender = "Male",
                motto = "Spread love wherever you go.",
            });

        }

        public void AddUser(User user)
        {
            dummyUsers.Add(user);
        }
        public User GetUser(string username)
        {
            return dummyUsers.Find(a => a.userName == username);
        }
    }
}