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
        public User User  {get;}
        
        public UserController(string userName, string genderName, DateTime bithDate, double weight, double height)
        {
            var gender = new Gender(genderName);
            User = new User(userName, gender, bithDate, weight, height);
        }
        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
            }
        }

        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }

        


       
    }
}
