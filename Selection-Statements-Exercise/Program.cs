namespace Selection_Statements_Exercise
{

//Create a program that allows a user to play a game where they must guess what your favorite number is:

    class Program
    {
        static void Main(string[] args)
        { 
            var Random = new Random();

            var favNumber = Random.Next(1, 11);

            int userInput = 0;

            while (userInput != favNumber)
            {

                Console.WriteLine("Guess my favorite number:");

                userInput = int.Parse(Console.ReadLine());

                if (favNumber < userInput)
                {
                    Console.WriteLine($"Too High!\nYourGuess:  {userInput}");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine($"Too Low!\nYourGuess:  {userInput}");
                }
                else
                {
                    Console.WriteLine($"You're psychic!\nThe number is {favNumber}");
                }
            }
        }

    }
}