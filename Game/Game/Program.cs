using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of different character types
            GameCharacter pressurer = new Pressurer();
            GameCharacter dominator = new Dominator();

            while (true)
            {
                Console.WriteLine("Select a character:");
                Console.WriteLine("1. Pressurer");
                Console.WriteLine("2. Dominator");
                Console.WriteLine("4. Exit");

                // Read user input
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        PlayGame(pressurer);
                        break;

                    case "2":
                        PlayGame(dominator);
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void PlayGame(GameCharacter character)
        {
            Console.WriteLine("Game started with character: " + character.GetType().Name);

            while (true)
            {
                Console.WriteLine("Enter an option:");
                Console.WriteLine("1. Move");
                Console.WriteLine("2. Speak");
                Console.WriteLine("3. Fight");
                Console.WriteLine("4. Gain Momentum");
                Console.WriteLine("5. Exit");

                // Read user input
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        character.Move();
                        break;

                    case "2":
                        character.Speak();
                        break;

                    case "3":
                        character.Fight();
                        break;

                    case "4":
                        character.GainMomentum();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}