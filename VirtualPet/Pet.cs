using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{


    public class Pet
    {
        public Pet()
        {
        }


        public string Name { set; get; }
        public string Species { set; get; }
        public int Hunger { set; get; }
        public int Boredom { set; get; }

        public int Health { set; get; }


        public void SetName(string name) { this.Name = name; }
        public string GetName() { return this.Name; }

        public void SetSpecies(string sp) { this.Species = sp; }
        public string GetSpecies() { return this.Species; }
        public int GetHunger() { return this.Hunger; }

        public int GetBoredom() { return this.Boredom; }

        public int GetHealth()
        {
            return this.Health;
        }

        public void Feed()
        {
            this.Hunger += 40;
            Console.WriteLine("You fed your pet");
            Console.ReadKey();
        }

        public void SeeDoctor()
        {
            this.Health += 30;
            Console.WriteLine("You took your pet to the Doctor");
            Console.ReadKey();
        }

        public void Tick()
        {
            if ((this.Boredom += 5) > 100)
            {
                this.Boredom = 100;
            }
            else
            {
                this.Boredom += 5;
            }

            if ((this.Health -= 5) < 0)
            {
                this.Health = 0;
            }
            else
            {
                this.Health -= 5;
            }

            if ((this.Hunger += 5) > 100)
            {
                this.Hunger = 100;
            }
            else
            {
                this.Health += 5;
            }
            // will prevent amounts going over 100 or into negatives; caps them off by setting a "max/min"
            //Console.WriteLine( Boredom);
            //Console.WriteLine(Hunger);
            //Console.WriteLine()
            // Console.WriteLine("Pet Status: Boredom  {0}  Hunger  {1}  Health  {2} ", this.Boredom, this.Hunger, this.Health);
        }


        public void Play()
        {
            this.Boredom += 10;
            Console.WriteLine("You played with your pet");
            Console.ReadKey();
        }




        public void CheckStatus()
        {

            Console.WriteLine("Bored Level " + GetBoredom());
            Console.WriteLine("Hunger Level " + GetHunger());
            Console.WriteLine("Health Level " + GetHealth());
            Console.ReadKey();
        }
    }
}