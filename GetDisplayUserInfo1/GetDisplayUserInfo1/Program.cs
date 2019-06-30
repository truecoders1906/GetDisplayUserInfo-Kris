using System;

namespace GetDisplayUserInfo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int favoriteNumber;
            int petCount;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("What is your favorite number?");
            favoriteNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many pets do you have?");
            petCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is " + firstName + " " + lastName);
            Console.WriteLine("Your favorite number is " + favoriteNumber);
            Console.WriteLine("You have " + petCount +" " + "pet(s)");
        }
    }
}
