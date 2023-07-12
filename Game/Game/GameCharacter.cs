using System;

namespace Game
{
    public class GameCharacter
    {
        public virtual void Move()
        {
            Console.WriteLine("Default Character Moves");
            // Logic to move
        }
        public virtual void Speak()
        {
            Console.WriteLine("Default Character Speaks");
            // Logic to speak
        }
        public virtual void Fight()
        {
            Console.WriteLine("Default Character Fights");
            // Logic to fight
        }
        public virtual void GainMomentum()
        {
            Console.WriteLine("Default Character GainMomentum");
            // Logic to GainMomentum
        }
    }
}
