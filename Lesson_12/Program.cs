using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var dateToday = new DateTime(2019, 11, 1);
            Console.WriteLine(dateToday);
            var dayOfWeek = dateToday.DayOfWeek;
            Console.WriteLine(dayOfWeek);*/

            int day;
            int month;
            int year;
            string userInput;

            Console.WriteLine("Enter your birth date and year yyyy/mm/dd:");
            userInput = Console.ReadLine();

            /*string[] userData = userInput.Split('/');
            year = int.Parse(userData[0]);
            month = int.Parse(userData[1]);
            day = int.Parse(userData[2]);

            var userBirthday = new DateTime(year, month, day);
            var birthdayDayOfTheWeek = userBirthday.DayOfWeek;
            Console.WriteLine($"{birthdayDayOfTheWeek}");*/


            GetUserInput(userInput);

             Console.ReadLine();
        }
        public static void GetUserInput(string userInput)
        {
            string[] userData = userInput.Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int year = int.Parse(userData[0]);
            int month = int.Parse(userData[1]);
            int day = int.Parse(userData[2]);

            foreach (string element in userData)
            {
               
                Console.WriteLine(element);
                
            }

            var userBirthday = new DateTime(year, month, day);
            var birthdayDayOfTheWeek = userBirthday.DayOfWeek;
            Console.WriteLine($"{birthdayDayOfTheWeek}");


        }

    }
}
