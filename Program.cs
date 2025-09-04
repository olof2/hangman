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
        while (true)
        {
            Console.WriteLine(guess);
        }

        // *** end or exit


        // *** shutdown and cleanup

    }
}