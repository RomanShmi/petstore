using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Shelter
    {
        public List<Pet> ListOfPets = new List<Pet>();

        public void AddPet(Pet pet1)
        {
            ListOfPets.Add(pet1);
        }

        public Pet PickAPet()
        {
            Console.Clear();

            Console.WriteLine("Please pick a pet from the list:  ");
            int index = 1;

            foreach (Pet pet1 in ListOfPets)
            {
                Console.WriteLine($"{ index}.{ pet1}");
                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());

            return ListOfPets[indexSelected - 1];
           
        }

        public void Adopt(Pet pet1)
        {
            ListOfPets.Remove(pet1);
        }

      public void CheckAllStats()
        {
            int index = 1;
            foreach (Pet pet1 in ListOfPets)
            {
                Console.WriteLine($"{ index}.{ pet1}");
                Console.WriteLine($"{pet1.GetName()}, {pet1.GetSpecies()}");
                pet1.CheckStatus();
                index++;
            }
        }


    } 


}
