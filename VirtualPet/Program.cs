using System;

using System.Threading;



namespace VirtualPet

{

    class Program
    {
        public static Pet pet1 = new Pet();

        public static Shelter MyShelter = new Shelter();

        private static Timer _timer;
        static void Main(string[] args)
        {
            
            PlayThemeSong();
            RunAnimatedMenu();

            Console.WriteLine("Welcome to the Pet Shop!");
            Console.WriteLine("There are many cute pets just waiting to be your friend.");
            Console.WriteLine("What kind of pet do you pick? Enter its species:");
            string petSpecies = Console.ReadLine();
            Console.WriteLine("What a cute " + petSpecies + " you picked!");
            Console.WriteLine("What would you like to name your pet?");
            string petName = Console.ReadLine();

            _timer = new Timer(Tick, null, 0, 15000);


            MyShelter.AddPet(pet1);


            //initialize pet attributes

            /*
             New Game -> Create First Pet ->
                    Manage Single Pet Menu .... at end <Manage Shelter>
                    -> Manage Shelter Menu
             */

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
                        pet1.CheckStatus();
                        break;
                    case "2":
                        pet1.Feed();
                        break;
                    case "3":
                        pet1.Play();
                        break;
                    case "4":
                        pet1.SeeDoctor();
                        break;
                    case "q":
                        keepPlaying = false;
                        break;
                    default:
                        break;



                        // create "go to/manage shelter" option on menu
                        // ?need nested loop to access shelter options?
                        // multi pet interactions?
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

            Console.WriteLine("Tick");

        }
    }
}
