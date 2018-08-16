using System;

namespace CG_6_5_Zodiac
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Finally, display their zodiac symbol and a fake fortune for them.You can get the list of zodiac signs and dates, 
             * as well as a sample, from Bing to an external site.*/

            Console.WriteLine("What is your Zodiac sign?");
            Console.WriteLine(); //line break for ease of reading

            //prompt for date of birth
            Console.Write("Please enter your date of birth (MM/DD/YYYY): ");

            //declare as datetime and name variable, and then convert from string to datetime using parse
            DateTime userBirthdate = DateTime.Parse(Console.ReadLine());
            
            //determine day of week birthdate is using the ToString method and print it to console
            Console.WriteLine("You were born on a {0}.", userBirthdate.ToString("dddd"));

            DateTime currentdate = DateTime.Now;
            //assign variable name and type to current date

            DateTime nextBDay = new DateTime(currentdate.Year, userBirthdate.Month, userBirthdate.Day);
            //create new datetime variable for birthday in current year to use in if/else if statements below

            //if day of year of your birthday is greater than or equal to current day of year,
            //the day of week will be determined by using current year
            //print day of the week to console using ToString
            if (userBirthdate.DayOfYear >= currentdate.DayOfYear)
            {
                Console.WriteLine("Your next birthday will be on a {0}.", nextBDay.ToString("dddd"));
            }


            //if day of year of your birthday has happened already this year, add 1 year to date to get correct day
            //print to console using ToString
            else if (userBirthdate.DayOfYear < currentdate.DayOfYear)
            {
                DateTime nextBDdayofwk = nextBDay.AddYears(1);
                Console.WriteLine("Your next birthday will be on a {0}", nextBDdayofwk.ToString("dddd"));
            }





            //if (sign = "Aries")
            //    Console.WriteLine("Fortune: You will reconnect with an old friend this month.");
            //else if (sign = "Taurus")
            //    Console.WriteLine("Fortune: You will trip over your own shoelace tomorrow.");
            //else if (sign = "Gemini")
            //    Console.WriteLine("Fortune: You will find a worm in the next apple you eat.");
            //else if (sign = "Cancer")



            

            






            Console.ReadLine();
        }

        //private static string Zodiac(DateTime userBirthdate)
        //{
            

        //    //string birthMonth = userBirthdate.ToString("MM");
        //    //string birthDay = userBirthdate.ToString("dd");
        //    //int birthMonthInt = int.Parse(birthMonth);
        //    //int birthDayInt = int.Parse(birthDay);

        //    if ()
        //    {

        //    }

            

        //}








    }
}
