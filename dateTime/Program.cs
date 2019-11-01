using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDate = DateTime.Now;
            var dataObject = new DateTime(2019, 11, 01);
            Console.WriteLine(currentDate);

            var currentDayOfTheWeek = currentDate.DayOfWeek;
            Console.WriteLine(currentDayOfTheWeek);

            var tick = dataObject.Ticks; //seconds since Jan 1, 1970
            Console.WriteLine($"Ticks {tick}");



            Console.WriteLine($"Print current date: {currentDate}");
            Console.WriteLine($"Print long date string: {currentDate.ToLongDateString()}");
            Console.WriteLine($"Print short date string: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Print long time string: {currentDate.ToLongTimeString()}");
            Console.WriteLine($"Print short time string: {currentDate.ToShortTimeString()}");
            Console.WriteLine($"Date format: {currentDate.ToString("yyyy-MM-dd HH:mm")}");


            ///konventeerida vanus sekundidesse. Küsida millal sündis.

            Console.ReadLine();
        }
    }
}
