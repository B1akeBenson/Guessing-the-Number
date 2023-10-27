using System.Runtime.InteropServices;

    class Program
    
    {
    static void Main(string[] args)
        {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;
        String response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            response = "";
            number = random.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("In this you will guess a number between 1-100, I will tell you if you are too high or too low");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);

                if (guess > number)
                {
                    Console.WriteLine(guess + "is too high!");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + "is too low!");
                }
                guesses++;

            }
            Console.WriteLine("Number: ");
            Console.WriteLine("YOU WIN!");
            Console.WriteLine("Guesses: " + guesses);

            Console.WriteLine("Would you like to play again (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }

        Console.WriteLine();

        Console.WriteLine("Thanks for playing!");

        Console.ReadKey();
        }
    }
