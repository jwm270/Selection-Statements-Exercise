namespace Selection_Statements_Exercise
{

//Create a program that allows a user to play a game where they must guess what your favorite number is:

    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            var favNumber = r.Next(1, 100);

            Console.WriteLine("Guess my favorite number:");

            int userInput = int.Parse(Console.ReadLine());

            if (favNumber < userInput)
            {
                Console.WriteLine("Too High");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("You're psychic!");
            }
        }

    }
}