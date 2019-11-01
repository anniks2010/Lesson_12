using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1,2,3,4,5}; ///using System.Collections.Generic; lisada ülesse, kui Listi ei saa kasutada
            numbers.Add(1); //lisab massiivi muutuja juurde lõppu.
            numbers.AddRange(new int[3] { 6, 7,8 }); ////saab mitu muutujat massiivi lisada

        

            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }

            int index = numbers.IndexOf(1);
            Console.WriteLine($"Value of IndexOf: {index}");

            int lastIndex = numbers.LastIndexOf(1);
            Console.WriteLine($"Value of IndexOf: {lastIndex}");

            /*numbers.RemoveAt(lastIndex);

            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }*/

            int sizeOfList = numbers.Count;
            Console.WriteLine($"Your list is: {sizeOfList} long");

            int sumOfList = numbers.Sum();
            Console.WriteLine($"Sum of list is: {sumOfList}");

            for (int i=0; i< numbers.Count;i++)
            {
                if (numbers[i]==1)
                {
                    numbers.Remove(numbers[i]);
                }

            }

            numbers.Clear();

            foreach (int element in numbers)
            {
                Console.WriteLine($"List after clear() :{element}");
            }

                Console.ReadLine();

            ///Whiliga küsida tooted, Console.Clear puhastada list, kuvada tooted kasutajale ning küsida, kas soovib veel midagi veel lisada. äkki soovib midagi eemaldada.
            ///lõpuks küsida kas nüüd on lõplik. Kasutada funktsioone.

        }
    }
}
