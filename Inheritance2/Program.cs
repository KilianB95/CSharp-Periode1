using System;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    
    abstract class onPickup
    {
        public virtual void PickUp()
        {

        }
        void MouseClick(float x, float y)
        {

        }
    }
    
    abstract class Equipment:onPickup
    {
        public virtual void Equip()
        {

        }
    }
    class Armor:Equipment
    {
        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("Draconic Armor");
        }
    }
    class Weapon:Equipment
    {
        public override void Equip()
        {
            base.Equip();
            Console.WriteLine("Deadric GreatSword");
        }
    }
    class HealPotion : onPickup
    {
        public override void PickUp()
        {
            base.PickUp();
            Console.WriteLine("Greater Heal Potion");
        }
        class ManaPotion : onPickup
        {
            public override void PickUp()
            {
                base.PickUp();
                Console.WriteLine("Greater Mana Potion");
            }
        }

    }
    
}
