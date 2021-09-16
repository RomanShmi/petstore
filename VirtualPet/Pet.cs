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
        public int GetHunger() { return 50; }

        public int GetBoredom() { return 60; }

        public int GetHealth()
        {
            return this.Health;
        }
   //   
   //     public int GetHealth() {
   //
     //       this.Health = 30;
       //     return this.Health;
      //  }



    }
}
