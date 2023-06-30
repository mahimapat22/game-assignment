using System;

namespace Game
{
    public abstract class GameCharacter
    {
        public virtual void Move()
        {
            Console.WriteLine("Character Moves");
            // Logic to move
        }
        public virtual void Speak()
        {
            Console.WriteLine("Character Speaks");
            // Logic to speak
        }
        public virtual void Fight()
        {
            Console.WriteLine("Character Fights");
            // Logic to fight
        }
        public abstract void GainMomentum();
    }
}
