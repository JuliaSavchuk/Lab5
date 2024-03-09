namespace GameNum
{
    public class NumGame
    {
        public static void Game()
        {
            Console.WriteLine("Welcome to the game \"Guess the number\"!");
            Console.WriteLine("Say a number from 1 to 100 and I'll try to guess.");

            int min = 1;
            int max = 100;
            string input;

            do
            {
                int guess = (min + max) / 2;
                Console.WriteLine($"Is it a number {guess}? (Yes/No)");
                input = Console.ReadLine();

                if (input.ToLower() == "yes")
                {
                    Console.WriteLine("Hooray! I guessed!");
                    break;
                }
                else if (input.ToLower() == "no")
                {
                    Console.WriteLine($"Is your number less {guess}? (Yes/No)");
                    input = Console.ReadLine();

                    if (input.ToLower() == "yes")
                    {
                        max = guess - 1;
                    }
                    else if (input.ToLower() == "no")
                    {
                        min = guess + 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
                }

            } while (true);

            Console.ReadLine();
        }
    }
}
