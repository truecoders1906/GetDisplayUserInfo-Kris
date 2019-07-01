using System;
using System.Collections.Generic;

namespace GetDisplayUserInfo1
{
    class Program
    {        

        static void getUserName()
        {
          Console.WriteLine("What is your first and last name?");
        }
        static void Main(string[] args)
        {
            string name;
            int favoriteNumber;
            int petCount;

            getUserName();
            name = Console.ReadLine();
                       
            Console.WriteLine("What is your favorite number?");
            favoriteNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many pets do you have?");
            petCount = Convert.ToInt32(Console.ReadLine());

            if (petCount != 0)
            {

                List<string> petName = new List<string>();
                for (int i = 0; i < petCount; i++)
                {
                    Console.WriteLine("What is the name of your pet? ", i + 1);
                    petName.Add(Console.ReadLine());
                }
                Console.WriteLine("Your name is " + name + ".");
                Console.WriteLine("Your favorite number is " + favoriteNumber);
                Console.WriteLine("You have " + petCount + " " + "pet(s)");
                Console.WriteLine("Your pet(s) names are:");
                petName.ForEach(Console.WriteLine);

            }
            else
            {
                
                Console.WriteLine("Your name is " + name + ".");
                Console.WriteLine("Your favorite number is " + favoriteNumber);
                Console.WriteLine("You have " + petCount + " " + "pet(s)");
            }

            
            

        }
    }
}
