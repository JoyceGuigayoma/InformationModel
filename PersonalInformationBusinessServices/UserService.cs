using PersonalInformationDataServices;
using PersonalInformationModel;
using System.ComponentModel;


namespace PersonalInformationBusinessServices
{
    public class UserService
    {
        private UserDataService dataService;

        public UserService()
        {
            dataService = new UserDataService();
        }

        public string GetUserPersonalInfo(string userName, string password)
        {
            User dummyUsers = dataService.GetUser(userName);
            if (dummyUsers != null && dummyUsers.password == password)
            {
                return GetInfo(dummyUsers);
            }
            else if (dummyUsers == null)
            {
                return "User not Found.";
            }
            else
            {
                return "Incorrect password.";
            }
        }

        public string AddPersonalInfo(string userName, string password, string fullName, string course, string address, string phoneNumber, string emailAddress, string dateOfBirth, string gender, string motto)
        {
            User newUser = new User
            {
                userName = userName,
                password = password,
                fullName = fullName,
                course = course,
                address = address,
                phoneNumber = phoneNumber,
                emailAddress = emailAddress,
                dateOfBirth = dateOfBirth,
                gender = gender,
                motto = motto,
            };

            dataService.AddUser(newUser);
            return GetInfo(newUser);
        } 
        private string GetInfo(User user)
        {
            return $"Name: {user.fullName}\nCourse: {user.course}\nAddress: {user.address}\nPhone Number: {user.phoneNumber}\nEmail Address: {user.emailAddress}\nDate of Birth: {user.dateOfBirth}\nGender: {user.gender}\nMotto: {user.motto}";
        }

    }
}
