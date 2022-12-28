using System;
using System.Collections.Generic;
using System.Text;

namespace UserApp
{
    internal class SocialMedia
    {
        public SocialMedia(string name)
        {
            Name = name;
        }
        public string Name;

        public User[] Users=new User[0];

        public void UserRegister()
        {
            var user = CreateUser();
            Array.Resize(ref Users, Users.Length+1);
            Users[Users.Length - 1] = user;
        }

        public void ShowUsers()
        {
            for (int i = 0; i < Users.Length; i++)
            {
                Console.WriteLine(Users[i].GetInfo());
            }
        }

        public User[] SearchUsers(string str)
        {
            str = str.ToLower();
            User[] searchedUsers = new User[0];

            for (int i = 0;i < Users.Length; i++)
            {
                if (Users[i].UserName.ToLower().Contains(str))
                {
                    Array.Resize(ref searchedUsers, searchedUsers.Length + 1);
                    searchedUsers[searchedUsers.Length - 1] = Users[i];
                }
            }

            return searchedUsers;
        }

        private User CreateUser()
        {
            string username;
            do
            {
                Console.WriteLine("UserName: ");
                username = Console.ReadLine();

            } while (!CheckUserName(username));

            string password;
            do
            {
                Console.WriteLine("Password");
                password = Console.ReadLine();
            } while (!CheckPassword(password));

            User user = new User(username, password);

            return user;
        }

        private bool CheckPassword(string password)
        {
            if (!string.IsNullOrWhiteSpace(password) && password.Length >= 8 && password.Length <= 25)
            {

                bool hasDigit = false;
                bool hasUpper = false;
                bool hasLower = false;
                for (int i = 0; i < password.Length; i++)
                {
                    if (!hasDigit && char.IsDigit(password[i]))
                        hasDigit = true;
                    else if (!hasLower && char.IsLower(password[i]))
                        hasLower = true;
                    else if (!hasUpper && char.IsUpper(password[i]))
                        hasUpper = true;

                    if (hasUpper && hasLower && hasDigit)
                        return true;
                }
            }

            return false;
        }

        private bool CheckUserName(string username)
        {
            if (!string.IsNullOrWhiteSpace(username) && username.Length >= 6 && username.Length <= 25)
            {
                return true;
            }
            return false;
        }
    }
}
