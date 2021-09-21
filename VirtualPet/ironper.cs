using System;

namespace VirtualPet
{
    class Ironper : Pet
    {
        //public int chargLevel;

        public bool chargingMode;
        public void HookupCharger() 
        { 
            this.chargingMode = true; 
        }

        public void UnHookCharger() 
        { 
            this.chargingMode = false; 
        }

        public override void Tick() 
        {
            if (chargingMode == true)
            {
                this.Health += 10;
            }
            else this.Health -= 1;
        }

        public override void CheckStatus() 
        { 
            base.CheckStatus();
            Console.WriteLine( "Charging mode is "+ chargingMode);
        }

        public override void Play() 
        {
            chargingMode = false; 
            base.Health -= 20; 
        }
        public override void Feed() 
        {
            HookupCharger(); 
            Tick();
        }

    }
}
