using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{

   
    public class Pet
    {
        public Pet(string name, string species)
        {
            this.Name = name;
            this.Species = species;
            this.Health = 60;
            this.Hunger = 60;
            this.Boredom = 20;
        
        }
        public Pet() { }

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

        public int GetBoredom() {  return this.Boredom; }
            
        public int GetHealth()
        {
            return this.Health;
        }
        
        public void Feed() {

          //  Console.WriteLine(this.Hunger);
            this.Hunger -=40;
          //  Console.WriteLine(this.Hunger);
        }

        public void SeeDoctor() {

          //  Console.WriteLine(this.Health);
            this.Health += 30;
           // Console.WriteLine(this.Health);
        
        }
        
        public void Play() {  this.Hunger+= 10; this.Health -= 15; }

        public void Tick() { this.Boredom += 5; this.Health -= 5; }


        public void CheckStatus()
        { Console.WriteLine(" helth "+this.Health+" hunger "+ this.Hunger+ "  bordem "+this.Boredom);
          //  Console.ReadLine();
        }




    }
}
