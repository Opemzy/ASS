using System;

namespace ASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a full time or part time student?");
            string answer = Convert.ToString(Console.ReadLine());
            
            if (answer == "full time")
            {
            Console.WriteLine("What is your course of study?");
            string course = Convert.ToString(Console.ReadLine());
            Console.WriteLine(course + " is a good course.");
            }
            else if (answer == "part time")
            {
                Console.WriteLine("How many credit are you taking?");
                int credit = Convert.ToInt32(Console.ReadLine());

                if (credit > 6)
                {
                    Console.WriteLine("Too much unit for a part-time student");
                }

                else if( credit <= 6)
                {
                    Console.WriteLine("Proceed");
                }

                
            }
            else 
            {
                Console.WriteLine("Error");
            }

        }
    }
}
