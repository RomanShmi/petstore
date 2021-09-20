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

        public int Health { set;  get; }

      
        public void SetName(string name) { this.Name = name; }
        public string GetName() { return this.Name; }

        public void SetSpecies(string sp) {  this.Species=sp; }
        public string GetSpecies() { return this.Species; }
        public int GetHunger() {  return this.Hunger; }

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

        public void Play()
        {
            this.Boredom += 10;
            Console.WriteLine("You played with your pet");
            Console.ReadKey();
        }

        public void Tick() { this.Boredom += 5; this.Health -= 5; }


        public void CheckStatus()
        {
            
            Console.WriteLine("Bored Level " + GetBoredom());
            Console.WriteLine("Hunger Level " + GetHunger());
            Console.WriteLine("Health Level " + GetHealth());
            Console.ReadKey();
        }

    }
}
