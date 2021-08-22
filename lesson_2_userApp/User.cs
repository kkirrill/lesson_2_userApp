﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2_userApp
{
    class User
    {
        public int Id { get; set; }
        private string Login, Password, Email;

        public string login
        {
            get { return Login; }
            set { Login = value; }
        }

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public User() { }
        public User(string Login, string Password, string Email)
        {
            this.Login = Login;
            this.Password = Password;
            this.Email = Email;
        }

        /*public override string ToString()
        {
            return "Пользователь: " + login + " Почта: " + email;
        }*/
    }
}
