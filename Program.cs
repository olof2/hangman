using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        // *** init
        int lives = 8;
        string secretWord = "giraffe";
        StringBuilder guess = new StringBuilder();
        StringBuilder guessedLetters = new StringBuilder();

        for(int i = 0; i < secretWord.Length; i++)
        {
            guess.Append("_");
        }

        // *** gameloop
        Console.WriteLine("game starts! type '1' to exit");
        while (true)
        {
            Console.WriteLine(guess.ToString() + ". Lives: " + lives.ToString());


            // Fetch input
            string? input = Console.ReadLine();

            //validate input
            if (input == null || input.Length == 0) {
                Console.WriteLine("invalid input, try again");
                continue;
            }

            //creating exit-code
            if (input == "1") { break; };


            char letter = input[0];
            Console.WriteLine("you guessed " + letter);


            // check if guessed letter is correct
            bool correct = false;
            //bool repeatLetter = false;
            for(int i = 0; i<secretWord.Length; i++)
            {
                if (letter == secretWord[i])
                {
                    correct = true;
                    guess[i] = letter;
                }
            }

            // check if letter is already guessed
            for(int i = 0; i < guessedLetters.Length; i++)
            {
                if (letter == guessedLetters[i])
                {
                    //Console.Clear();
                    correct = true;
                    Console.WriteLine("you have already guessed " + letter);
                }
            }

            guessedLetters.Append(letter);

            if (!correct) { lives--; };


            if (lives == 0) { Console.WriteLine("out of lives! you lost!"); break; }
            if (secretWord == guess.ToString()) { Console.WriteLine("you won! you have " + lives + " lives left!"); break; }
        }

        // *** end or exit


    }
}