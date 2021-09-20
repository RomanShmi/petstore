using System;

using System.Threading;



namespace VirtualPet

{

    class Program
    {
        static void Main(string[] args)
        {
            Timer _timer = new Timer(Tick, null, 0, 15000);
            //PlayThemeSong();
            RunAnimatedMenu();

            //options menu: create a new pet or exit

            bool keepPlaying = true;
            while (keepPlaying == true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Press N to create a new pet!");
                Console.WriteLine("Press Q to exit.");
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "n":
                        MainGame();
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

        public static void MainGame()
        {
            Console.WriteLine("Welcome to the Pet Shop!");
            Console.WriteLine("There are many cute pets just waiting to be your friend.");
            Console.WriteLine("What kind of pet do you pick? Enter its species:");
            string petSpecies = Console.ReadLine();
            Console.WriteLine("What a cute " + petSpecies + " you picked!");
            Console.WriteLine("What would you like to name your pet?");
            string petName = Console.ReadLine();

            Pet pet1 = new Pet();

            pet1.SetSpecies(petSpecies);
            pet1.SetName(petName);

            //initialize pet attributes

            Console.WriteLine(petName + " looks tired and hungry! You should take them home.");

            bool keepPlaying = true;
            while (keepPlaying == true)
            {
                Console.Clear();
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
                        //method to check pet status
                        CheckStatus(pet);
                        break;
                    case "2":
                        //method to feed pet
                        //PLACEHOLDER;
                        break;
                    case "3":
                        //method to play with pet
                        //PLACEHOLDER;
                        break;
                    case "4":
                        //method to take pet to doctor    git push --set-upstream origin timer

                        //PLACEHOLDER;
                        break;
                    case "q":
                        keepPlaying = false;
                        break;
                    default:
                        break;

                }

            }
        }
        public static void CheckStatus(Pet pet)
        {
            Console.Clear();

            Console.WriteLine("You look at your pet.\n\n");

            //Checks Hunger
            int hunger = pet.GetHunger();

            if (hunger > 100)
            {
                Console.WriteLine("Your pet looks like they are starving!");
            }
            else if ((hunger < 100) && (hunger >= 75))
            {
                Console.WriteLine("Your pet looks like they are very hungry.");
            }
            else if ((hunger < 75) && (hunger >= 50))
            {
                Console.WriteLine("Your pet looks hungry.");
            }
            else if ((hunger < 50) && (hunger >= 25))
            {
                Console.WriteLine("Your pet does not look hungry.");
            }
            else
            {
                Console.WriteLine("Your pet looks very well fed!");
            }

            Console.WriteLine("Your pet's Hunger Level is currently at " + hunger);


            //Checks Boredom
            int boredom = pet.GetBoredom();

            if (boredom > 120)
            {
                Console.WriteLine("Your pet looks like they are ready to start tearing your house apart!");
            }
            else if ((boredom < 120) && (boredom >= 90))
            {
                Console.WriteLine("Your pet looks very restless.");
            }
            else if ((boredom < 90) && (boredom >= 60))
            {
                Console.WriteLine("Your pet looks restless.");
            }
            else if ((boredom < 60) && (boredom >= 30))
            {
                Console.WriteLine("Your pet looks content.");
            }
            else
            {
                Console.WriteLine("Your pet looks very happy!");
            }

            Console.WriteLine("Your pet's Boredom Level is currently at " + boredom);

            //Checks health
            int health = pet.GetHealth();

            if (health < 0)
            {
                Console.WriteLine("Your pet is almost dead!");
            }
            else if ((health > 0) && (health <= 15))
            {
                Console.WriteLine("Your pet looks very sick. :(");
            }
            else if ((health > 15) && (health <= 30))
            {
                Console.WriteLine("Your pet looks a little sick.");
            }
            else if ((health > 30) && (health <= 45))
            {
                Console.WriteLine("Your pet looks healthy.");
            }
            else
            {
                Console.WriteLine("Your pet is the picture of health!");
            }


            //Displays hunger meter
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nHunger");
            for (int i = hunger; i > 0; i--)
            {
                Console.Write("\'");
            }
           
            Console.Write("\n");

            //Displays boredom meter
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nBoredom");
            for (int j = boredom; j > 0; j--)
            {
                Console.Write("\'");
            }

            Console.Write("\n");

            //Displays health meter
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Health");
            for (int k = health; k > 0; k--)
            {
                Console.Write("\'");
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\nPress enter to return to your shelter.");
            Console.ReadLine();

        }
      
      public static void Tick(Object o)

        {

            // put methods/updates that change the pet in some way

            Console.WriteLine("Tick");

        }
    }
}
