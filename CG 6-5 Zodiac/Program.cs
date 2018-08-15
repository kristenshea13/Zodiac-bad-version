using System;

namespace CG_6_5_Zodiac
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Create a program that asks the user for the date they were born.
             * Display the name of the day they were born on(Ex: Thursday) and the name of the day their next birthday will be on.
             * Finally, display their zodiac symbol and a fake fortune for them.You can get the list of zodiac signs and dates, 
             * as well as a sample, from Bing to an external site.*/

            Console.WriteLine("What is your sign and horoscope?");
            Console.WriteLine();
            Console.Write("Please enter your birthdate (MM/DD/YYYY): ");
            DateTime userBirthdate = DateTime.Parse(Console.ReadLine());


            string zodiac1 = "Aries";
            string zodiac2 = "Pisces";





            Console.ReadLine();
        }

        private static string ZodiacSign();
        {
            
        }





    }
}
