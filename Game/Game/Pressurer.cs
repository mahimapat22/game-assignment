using System;

namespace Game
{
    public class Pressurer : GameCharacter
    {
        //Pressurer moves same as base game character;

        public override void Speak()
        {
            Console.WriteLine("Pressurer smiles");
            // Logic for Pressurer-specific Speaking behavior
        }

        public override void Fight()
        {
            base.Fight();
            Console.WriteLine("Pressurer fights as base game character and also smack");
            // Logic for Pressurer-specific fighting behavior
        }

        public override void GainMomentum()
        {
            Console.WriteLine("Pressure gains momentum.");
            // Logic for Pressurer gaining momentum
        }
    }
}