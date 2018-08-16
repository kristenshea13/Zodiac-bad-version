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

            Console.WriteLine("What is your Zodiac sign?");
            Console.WriteLine();
            Console.Write("Please enter your date of birth (MM/DD/YYYY): ");


            DateTime userBirthdate = DateTime.Parse(Console.ReadLine());

            string zodiacDay = userBirthdate.ToString("dd");
            string zodiacMonth = userBirthdate.ToString("MMM");




            //string sign = 

            if (sign = "Aries")
                Console.WriteLine("Fortune: You will reconnect with an old friend this month.");
            else if (sign = "Taurus")
                Console.WriteLine("Fortune: You will trip over your own shoelace tomorrow.");
            else if (sign = "Gemini")
                Console.WriteLine("Fortune: You will find a worm in the next apple you eat.");
            else if (sign = "Cancer")
                
            
          







            Console.ReadLine();
        }

        //private static string ZodiacSign(string zodiacMonth, string zodiacDay);
        //{
           
            
        
        //// if (string zodiacMonth = "Mar" && string zodiacDay >= 21 || string zodiacMonth = "Apr" && string zodiacDay <= 19 )
        //   //{
        //   //     return = "Aries";

        //   //}





        //}





    }
}
