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
    public class User
    {
        public string Name { get; }
        public Gender Gender { get; }
        public DateTime BirthDate { get; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime Birthdate { get; }

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
        
    }
}
