using System;

namespace Game
{
    public class Pressurer : GameCharacter
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Pressurer moves and jumps.");
            // Logic for Pressurer-specific Moving behavior

        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Pressurer speaks and smiles");
            // Logic for Pressurer-specific Speaking behavior
        }

        public override void Fight()
        {
            base.Fight();
            Console.WriteLine("Pressurer fights with smack");
            // Logic for Pressurer-specific fighting behavior
        }

        public override void GainMomentum()
        {
            Console.WriteLine("Pressure gains momentum.");
            // Logic for Pressurer gaining momentum
        }
    }
}
