using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

        // *** init
        int lives = 8;
        string secretWord = "giraffe";
        StringBuilder guess = new StringBuilder();
        for(int i = 0; i < secretWord.Length; i++)
        {
            guess.Append("_");
        }

        // *** gameloop
        Console.WriteLine("game starts!")
        while (true)
        {
            Console.WriteLine(guess.ToString + ". Lives: " + lives.ToString);

            // Fetch input
            string? input = Console.ReadLine();

            //validate input
            if (input == null || input.Length == 0) {
                Console.WriteLine("invalid input, try again")
                continue;
            }

            char letter = input[0]
            Console.WriteLine("you guessed " + letter)


            break;
        }

        // *** end or exit


        // *** shutdown and cleanup

    }
}