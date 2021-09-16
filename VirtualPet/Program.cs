using System;

using System.Threading;



namespace VirtualPet

{

    class Program

    {

        // we need a pet 'property' variable

        // public Pet myPet ...

        static void Main(string[] args)

        {

        //  Console.WriteLine("Hello! Welcome to Virtual Pets");

            // ask the user about their pet's info

            // reassign myPet's properties to be what the user provided

            // myPet.name = Console.ReadLine();

            Timer _timer = new Timer(Tick, null, 0, 15000);

            while (true)

            {

                // Ask the user what they want to do

                // etc.

            }

        }



        public static void Tick(Object o)

        {

            // put methods/updates that change the pet in some way

            Console.WriteLine("Tick");

        }

    }

}
