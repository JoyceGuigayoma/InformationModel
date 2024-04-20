using PersonalInformationBusinessServices;
using PersonalInformationDataServices;
using PersonalInformationModel;
using System;

namespace PersonalInformationUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService services = new UserService();

            while (true)
            {
                Console.WriteLine("Welcome to the Inforg Portal!");
                Console.WriteLine("___________________________________________________________________________________");
                Console.WriteLine("This is designed to help each member get to know their fellow members better.");
                Console.WriteLine("If you'd like to become a part of our community, please create an account.");
                Console.WriteLine("___________________________________________________________________________________");
                Console.WriteLine("1. Log in");
                Console.WriteLine("2. Create an account");
                Console.Write("Enter the number of your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your username: ");
                        string username = Console.ReadLine();

                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine();

                        string login = services.GetUserPersonalInfo(username, password);
                        if (login == "User not Found." || login == "Incorrect Password")
                        {
                            Console.WriteLine(login);
                        }
                        else
                        {
                            Console.WriteLine("___________________________________________________________________________________");
                            Console.WriteLine("Welcome to Inforg Portal! Here's your Personal Information.");
                            Console.WriteLine("___________________________________________________________________________________");
                            Console.WriteLine(login);
                        }
                       
                        break;

                    case 2:
                        Console.WriteLine("___________________________________________________________________________________");
                        Console.WriteLine("Please fill out your Personal Information!");
                        Console.WriteLine("___________________________________________________________________________________");

                        Console.Write("Enter username: ");
                        string newUsername = Console.ReadLine();

                        Console.Write("Enter password: ");
                        string newPassword = Console.ReadLine();

                        Console.Write("Enter your full name: ");
                        string fullName = Console.ReadLine();

                        Console.Write("Enter your course: ");
                        string course = Console.ReadLine();

                        Console.Write("Enter your address: ");
                        string address = Console.ReadLine();

                        Console.Write("Enter your phone number: ");
                        string phoneNumber = Console.ReadLine();

                        Console.Write("Enter your email address: ");
                        string emailAddress = Console.ReadLine();

                        Console.Write("Enter your date of birth: ");
                        string dateOfBirth = Console.ReadLine();

                        Console.Write("Enter your gender: ");
                        string gender = Console.ReadLine();

                        Console.Write("Enter your motto: ");
                        string motto = Console.ReadLine();

                        services.AddPersonalInfo(newUsername, newPassword, fullName, course, address, phoneNumber, emailAddress, dateOfBirth, gender, motto);
                        Console.WriteLine("Successfully created your account.");
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break ;
                }
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}