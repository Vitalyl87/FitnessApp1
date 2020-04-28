using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAppBL.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    
    [Serializable]
    public class User
    {
        public string Name { get; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime Birthdate { get; }

        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }

        public User(
            string name, 
            Gender gender, 
            DateTime birthdate, 
            double weight, 
            double height
            )
        {
            #region Проверка входных параметров
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя должно быть заполнено.", nameof(name));
            }

            if (gender is null)
            {
                throw new ArgumentNullException("Пол должен быть заполнен.", nameof(gender));
            }


            if (birthdate <= DateTime.Parse("01.01.1900") || birthdate > DateTime.Now)
            {
                throw new ArgumentNullException("Некорректно задано время события", nameof(birthdate));
            }

            if (weight < 0)
            {
                throw new ArgumentNullException("Вес не должен быть ниже нуля.", nameof(weight));
            }
            if (height < 0)
            {
                throw new ArgumentNullException("Рост не должен быть ниже нуля.", nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            Birthdate = birthdate;
            Weight = weight;
            Height = height;
        }

        public User(string userName)
        {
            if (userName is null || string.IsNullOrWhiteSpace(userName) || userName == "")
            {
                throw new ArgumentNullException("Имя не должно быть пустым", nameof(userName));
            }
            Name = userName;
        }
        public override string ToString()
        {
            return Name +" " + Age;
        }
    }
}
