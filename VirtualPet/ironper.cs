using System;

namespace VirtualPet
{
    class Ironper : Pet
    {
        //public int chargLevel;

        public bool chargingMode;
        public void HookupCharher() { this.chargingMode = true; }
        public void UnHookCharher() { this.chargingMode = false; }

        public void Charging(bool charger)
        {
            if (chargingMode == true) this.Health += 10;
            else this.Health -= 1;
        }

        public void TickI() { this.Charging(this.chargingMode);  }
        public void CheckStatusI() { base.CheckStatus(); Console.WriteLine( "Charghing mode is "+ chargingMode); }

        public void PlayI() { chargingMode = false; base.Health -= 20; }
        public void FeedI() { HookupCharher(); TickI(); }

    }
}
