using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using VirtualPet;

namespace VirtualPet

{

    class Program
    {

        public static Pet pet1;

        private static Timer _timer;
        static void Main(string[] args)
        {

            PlayThemeSong();
            RunAnimatedMenu();

            Console.WriteLine("Welcome to your animal shelter!");
            Console.WriteLine("What is the name of your shelter?");
            string shelterName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"On your way to {shelterName} you come across a small bundle. It's an animal!");
            Console.WriteLine("What kind of animal is it?\n Enter its species:");
            string petSpecies = Console.ReadLine();
            Console.WriteLine($"The {petSpecies} looks cold and tired. You take it back to {shelterName}.");
            Console.WriteLine($"When you arrive, you set the {petSpecies} up in an appropriate cage, and give it a name.");
            Console.WriteLine($"What is the {petSpecies}'s name?");
            string petName = Console.ReadLine();

            _timer = new Timer(Tick, null, 0, 2000);
            pet1 = new Pet();

            bool keepPlaying = true;

            while (keepPlaying == true)
            {
                Console.Clear();

                Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++     ");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Check your pet's status.");
                Console.WriteLine("2. Feed your pet.");
                Console.WriteLine("3. Play with your pet.");
                Console.WriteLine("4. Take your pet to the doctor.");
                Console.WriteLine("Press Q to exit the game.");

                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "1":
                        pet1.CheckStatus();
                        // Console.ReadLine();
                        break;
                    case "2":
                        pet1.Feed();
                        pet1.CheckStatus();
                        //Console.ReadLine();
                        break;
                    case "3":
                        pet1.Play();
                        pet1.CheckStatus();
                        //Console.ReadLine();
                        break;
                    case "4":
                        pet1.SeeDoctor();
                        pet1.CheckStatus();
                        //Console.ReadLine();
                        break;
                    case "5":
                        pet1.Tick();
                        pet1.CheckStatus();
                        //Console.ReadLine();
                        break;

                    case "q":
                        keepPlaying = false;
                        break;
                    default:
                        break;
                }
            }
        }
            public static void PlayThemeSong()
            {

                Console.Beep(262, 250); //C
                Console.Beep(294, 250); //D
                Console.Beep(330, 250); //E
                Console.Beep(294, 500); //D
                Console.Beep(262, 500); //C
                Console.Beep(392, 750); //G
            }

            public static void RunAnimatedMenu()
            {
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\tHello! Welcome to CyberPets! =^.u.^=\n\n\n\n\n");
                Console.WriteLine("\t\t\t\t\tPress any key to continue.");
                Console.ReadKey();
                Console.Clear();

                for (int i = 5; i > 0; i--)
                {
                    for (int j = i; j > 0; j--)
                    {
                        Console.Write("\n");
                    }
                    Console.WriteLine("\t\t\t\t\tHello! Welcome to CyberPets! =^.u.^=\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\tPress any key to continue.");
                    System.Threading.Thread.Sleep(250);
                    Console.Clear();
                }

                for (int k = 5; k > 0; k--)
                {
                    for (int l = k; l > 0; l--)
                    {
                        Console.Write("\n");
                    }
                    Console.WriteLine("\t\t\t\t\tPress any key to continue.");
                    System.Threading.Thread.Sleep(250);
                    Console.Clear();
                }
            }
        public static void Tick(Object o)
        {
            //Pet pet = new Pet();  

            pet1.Tick();  //will +5 Hunger/ +5 Boredom/ -5 Health

            // put methods/updates that change the pet in some way
        }

    }
}

