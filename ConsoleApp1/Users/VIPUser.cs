﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProjectCore;

namespace ConsoleApp1.Users
{
    class VIPUser : IUser
    {
        public VIPUser(string login, string password, long phone, Enum day, DateTime time)
        {
            Password = password;
            Login = login;
            Phone = phone;
            FavouriteDay = day;
            FavouriteTime = time;
        }
        public string Password { get; set; }
        public long Phone { get; set; }
        public string Login { get; set; }
        public Enum FavouriteDay { get; set; }
        public DateTime FavouriteTime { get; set; }
    }
}
