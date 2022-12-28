using System;
using System.Collections.Generic;
using System.Text;

namespace UserApp
{
    internal class User
    {
        public User(string username)
        {
            this.UserName = username;
            CreatedAt = DateTime.Now;
        }

        public User(string username,string password)
        {
            this.UserName = username;
            this.Password = password;
            CreatedAt = DateTime.Now;
        }
        private string _userName;
        private string _password;
        public readonly DateTime CreatedAt;
        //public DateTime CreatedAt { get; private set; }

        public string Password
        {
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
            }
        }
        public string UserName
        {
            get => this._userName;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && value.Length>=6 && value.Length <= 25)
                {
                    this._userName = value;
                }
                //else
                //{
                //    throw new FormatException("Username must be less or equal than 25 and greater or equal than 6");
                //}
            }
        }

        private bool CheckPassword(string password)
        {
            if(!string.IsNullOrWhiteSpace(password) && password.Length>=8 && password.Length <= 25)
            {
                //return HasDigit(password) && HasUpper(password) && HasLower(password);

                bool hasDigit = false;
                bool hasUpper = false;
                bool hasLower = false;
                for (int i = 0; i < password.Length; i++)
                {
                    if (!hasDigit && char.IsDigit(password[i]))
                        hasDigit = true;
                    else if(!hasLower && char.IsLower(password[i]))
                        hasLower = true;
                    else if(!hasUpper && char.IsUpper(password[i]))
                        hasUpper = true;

                    if (hasUpper && hasLower && hasDigit)
                        return true;
                }
            }

            return false;
        }

        private bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;
        }
        private bool HasLower(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    return true;
                }
            }
            return false;
        }
        private bool HasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public string GetInfo()
        {
            return $"UserName: {this.UserName}";
        }
    }
}
