using System;
using System.Collections.Generic;

namespace GetDisplayUserInfo1
{
    class Program
    {        
            static string getUserName(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }            
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I would like some basic information from you.");
            string firstName = getUserName("What is your first name?");
            string lastName = getUserName("What is your last name?");                      
                                                      
            Console.WriteLine("What is your favorite number?");
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many pets do you have?");
            int petCount = Convert.ToInt32(Console.ReadLine());

            if (petCount > 1)
            {
                List<string> petName = new List<string>();
                for (int i = 0; i < petCount; i++)
                {
                    Console.WriteLine("What is the name of your pet? ", i + 1);
                    petName.Add(Console.ReadLine());
                }
                Console.WriteLine("Your name is " + firstName + " " + lastName + ".");
                Console.WriteLine("Your favorite number is " + favoriteNumber);
                Console.WriteLine("You have " + petCount + " " + "pet(s)");
                Console.WriteLine("Your pet's names are:");
                petName.ForEach(Console.WriteLine);
            }
            else if(petCount == 0)
            {                
                Console.WriteLine("Your name is " + firstName + " " + lastName + ".");
                Console.WriteLine("Your favorite number is " + favoriteNumber);
                Console.WriteLine("You do not have any pets.");
            }
            else if(petCount == 1)
            {
                Console.WriteLine("What is the name of your pet?");
                string petName = Console.ReadLine();
                Console.WriteLine("Your name is " + firstName + " " + lastName + ".");
                Console.WriteLine("Your favorite number is " + favoriteNumber + ".");
                Console.WriteLine("Your pet's name is " + petName + ".");

            }
            
            

        }
    }
}
