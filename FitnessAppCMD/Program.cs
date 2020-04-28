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

            var userController = new UserController(username);

            if (userController.IsNewUser)
            {
                Console.WriteLine("Введите Ваш пол:");
                string gender = Console.ReadLine();
                userController.SetUserData(gender, DateParse(), DoubleParse("вес"), DoubleParse("рост"));
            }
            else { Console.WriteLine(userController.CurrentUser); }
            Console.ReadLine();



           

            


        }
        private static DateTime DateParse()
        {
            
            while (true)
            {
                Console.WriteLine("Введите дату Вашего рождения (dd.MM.YYYY):");
                string bDate = Console.ReadLine();
                if (DateTime.TryParse(bDate, out DateTime res) != false)
                {
                    return res;
                }
                else
                {
                    Console.WriteLine("Введен некорректный формат для даты.");
                }

            }
        }


        private static double DoubleParse(string type)
        {

            while (true)
            {
                Console.WriteLine($"Введите Ваш {type}:");
                string bDate = Console.ReadLine();
                if (double.TryParse(bDate, out double res) != false)
                {
                    return res;
                }
                else
                {
                    Console.WriteLine($"Введен некорректный формат для {type}.");
                }

            }
        }



    }
}
