﻿using FitnessAppBL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAppBL.Controller
{
    public class UserController
    {
        public List<User> Users  {get;}

        public bool IsNewUser { get; set; } = false;

        public User CurrentUser { get; }
        
        public UserController(string userName)
        {
            if (userName is null)
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(userName));
            }

            Users = GetUsersData();

            CurrentUser = Users.SingleOrDefault(u => u.Name == userName);
            if (CurrentUser == null)
            {
                CurrentUser = new User(userName);
                IsNewUser = true;
                Users.Add(CurrentUser);
                Save();
            }


        }
        public List<User> GetUsersData()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && formatter.Deserialize(fs) is List<User> user)
                {
                    return user;
                }
                else
                {
                    return new List<User>();
                }
            }
        }

        public void SetUserData(string genderName, DateTime birthDate, double weight, double height )
        {
            CurrentUser.Gender = new Gender(genderName);
            CurrentUser.BirthDate = birthDate;
            CurrentUser.Weight = weight;
            CurrentUser.Height = height;
            Save();
        }

        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Users);
            }
        }

        


       
    }
}
