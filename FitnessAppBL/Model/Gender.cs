using System;


namespace FitnessAppBL.Model
{
    /// <summary>
    /// Пол
    /// </summary>
    public class Gender
    {
        
        public string Name { get; }

        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Название не может быть пустым", nameof(Gender));
            }
            Name = name;
        }
    }
}
