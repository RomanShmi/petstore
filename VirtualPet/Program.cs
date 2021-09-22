using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using VirtualPet;

namespace VirtualPet

{

    class Program
    {

        public static Pet myPet;

        private static Timer _timer;
        static void Main(string[] args)
        {

            //PlayThemeSong();
            //RunAnimatedMenu();

            Console.WriteLine("Welcome to your animal shelter!");
            Console.WriteLine("What is the name of your shelter?");
            string shelterName = Console.ReadLine();
            Console.Clear();

            myPet = ChoosePetType(shelterName);
            SetNameAndSpecies(shelterName, myPet);

            _timer = new Timer(Tick, null, 0, 15000);

            bool keepPlaying = true;

            while (keepPlaying == true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ ");

                Console.WriteLine("What would you like to do?");
                if (myPet is Ironper)
                    Console.WriteLine("1. Check your robot's status.");
                else Console.WriteLine("1. Check your pet's status.");
                if (myPet is Ironper)
                    Console.WriteLine("2. Fill your robot up with oil.");
                else Console.WriteLine("2. Feed your pet.");
                if (myPet is Ironper)
                    Console.WriteLine("3. Play with your robot.");
                else Console.WriteLine("3. Play with your pet.");
                if (myPet is Ironper)
                    Console.WriteLine("4. Hook/Unhook your robot from charger.");
                else Console.WriteLine("4. Take your pet to the doctor.");
                Console.WriteLine("   Press Q to exit the game.");

                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "1":
                        myPet.CheckStatus();
                        break;
                    case "2":
                        myPet.Feed();
                        myPet.CheckStatus();
                        break;
                    case "3":
                        myPet.Play();
                        myPet.CheckStatus();
                        break;
                    case "4":
                        myPet.SeeDoctor();
                        myPet.CheckStatus();
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

        public static Pet ChoosePetType(string shelterName)
        {
            Console.WriteLine($"On your way to {shelterName} you come across a small bundle. It's an...animal or robot?");
            Console.WriteLine("Press 1 for animal, 2 for robot.");
            string petType = Console.ReadLine();

            //ADD ERROR CATCHING LOOP HERE
            if (petType == "1")
            {
                Pet myPet = new Pet();
                Console.WriteLine("The animal looks up at you!");
                return myPet;
            }
            else // if (petType == "2")
            {
                Ironper myPet = new Ironper();
                Console.WriteLine("The robot looks up at you!");
                return myPet;
            }
            /* else
             {
                 Console.WriteLine("Oops! Try again.");
             }*/

        }

        public static void SetNameAndSpecies(string shelterName, Pet myPet)
        {
            Console.WriteLine("What kind of animal is it?\n Enter its species:");
            string petSpecies = Console.ReadLine();
            myPet.SetSpecies(petSpecies);
            Console.WriteLine($"The {myPet.GetSpecies()} looks cold and tired. You take it back to {shelterName}.");
            Console.WriteLine($"When you arrive, you set the {myPet.GetSpecies()} up in an appropriate cage, and give it a name.");
            Console.WriteLine($"What is the {myPet.GetSpecies()}'s name?");
            string petName = Console.ReadLine();
            myPet.SetName(petName);
            Console.WriteLine("Press any key to continue!");
            Console.Read();
        }

        public static void Tick(Object o)
        {
            //Pet pet = new Pet();  

            myPet.Tick();  //will +5 Hunger/ +5 Boredom/ -5 Health

            // put methods/updates that change the pet in some way
        }

    }
}

