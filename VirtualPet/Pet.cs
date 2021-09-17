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
        
        public void Feed() {  this.Hunger-=40; }

        public void SeeDoctor() { this.Health += 30; }
        
        public void Play() {  this.Hunger+= 10; }

        public void Tick() { this.Boredom += 5; this.Health -= 5; }




    }
}
