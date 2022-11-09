using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        
        static bool cont = true;

        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        public static void Main(string[] args)
        {
            Random Rng = new Random();
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            bool cont;
            if(Console.ReadLine().ToLower() == "yes")
            {
                cont = true;
            }
            else
            {
                cont = false;
            }
            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            bool seeList;
            if (Console.ReadLine().ToLower() == "sure")
            {
                seeList = true;
            }
            else
            {
                seeList = false;
            }
            
            if (seeList == true)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity}");
                    Thread.Sleep(250);
                }
                Console.WriteLine();

                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList;
                if (Console.ReadLine().ToLower() == "yes")
                {
                    addToList = true;
                }
                else
                {
                    addToList = false;
                }
                Console.WriteLine();
                while (addToList == true)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    break;
                }
                Console.WriteLine("Would you like to add more? yes/no: ");
                if (Console.ReadLine().ToLower() == "no")
                {
                    while (addToList)
                    {
                        Console.Write("Connecting to the database");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    addToList = true;
                }
            }
            Console.Write("Choosing your random activity");
            for (int i = 0; i < 9; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }
            Console.WriteLine();
            int randomNumber = Rng.Next(activities.Count);
            string randomActivity = activities[randomNumber];
            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
            Console.WriteLine("Pick something else!");
            activities.Remove(randomActivity);

            Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
            Console.WriteLine();
            cont = bool.Parse(Console.ReadLine());
            if(Console.ReadLine().ToLower() == "keep")
            {
                Console.WriteLine($"You are now {randomActivity}!");
            }
            else
            {
                cont = false;
            }
        }
    } 
}
