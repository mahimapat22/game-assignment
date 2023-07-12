using System;

namespace Game
{

    public class Dominator : GameCharacter
    {
        public override void Move()
        {
            Console.WriteLine("Dominator swirls.");
            // Logic for Dominator-specific Moving behavior

        }

        ///Dominator speaks same as base game character;

        public override void Fight()
        {
            base.Fight();
            Console.WriteLine("Dominator fights and crashes");
            // Logic for Dominator-specific fighting behavior
        }

        public override void GainMomentum()
        {
            Console.WriteLine("Dominator gains momentum.");
            // Logic for Dominator gaining momentum
        }
    }
}