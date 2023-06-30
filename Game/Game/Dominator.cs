using System;

namespace Game
{

    public class Dominator : GameCharacter
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Dominator moves and swirls.");
            // Logic for Dominator-specific Moving behavior

        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Dominator speaks and wink.");
            // Logic for Dominator-specific Speak behavior

        }

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
