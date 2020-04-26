using System;
using FitnessAppBL.Controller;

namespace FitnessAppCMD
{
    class Program
    {
        /// <summary>
        /// Основное приложени
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя:");
            string username = Console.ReadLine();

            Console.WriteLine("Введите Ваш пол:");
            string gendername = Console.ReadLine();

            Console.WriteLine("Введите дату Вашего рождения:");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите Ваш вес:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите Ваш рост:");
            double height = double.Parse(Console.ReadLine());

            var userController = new UserController(username, gendername, birthdate, weight, height);
            userController.Save();


        }
    }
}
