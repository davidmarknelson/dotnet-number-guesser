using System;

// namespace
namespace number_guesser_net
{
  // Main class
  class Program
  {
    // Entry point method
    static void Main(string[] args)
    {
      // Run starter app info
      GetAppInfo();

      // Ask for user's name
      GreetUser();

      while (true) {
        // Create a new random object
        Random random = new Random();

        int correctNumber = random.Next(1, 10);

        // Initial guess variable
        int guess = 0;

        // Ask user for number
        Console.WriteLine("Guess a number between 1 and 10.");

        // While the guess isn't correct
        while (guess != correctNumber) {
          // get user input
          string input = Console.ReadLine();

          // Check that input is a number
          if (!int.TryParse(input, out guess)) {
            
            // print error message
            PrintColorMessage(ConsoleColor.Red, "Please type a number.");

            // keep going with the loop
            continue;
          }

          // cast to int and put in guess variable
          guess = Int32.Parse(input);

          // tell user it's the wrong number
          if (guess != correctNumber) {
            // print error message
            PrintColorMessage(ConsoleColor.Red, "Wrong number. Try again.");
          }
        }

        // Show a success message that it is the correct number
        // print success message
        PrintColorMessage(ConsoleColor.Cyan, $"You are correct! The number is {correctNumber}.");

        // Ask to play again
        Console.WriteLine("Play again? [Y or N]");

        // get answer
        string answer = Console.ReadLine().ToUpper();

        if (answer == "Y") {
          continue;
        }
        else {
          return;
        }
      }
    }

    static void GetAppInfo() {
      // set app variables
      string appName = "Number Guesser";
      string appVersion = "1.0.0";
      string appAuthor = "David";

      // Change text color
      Console.ForegroundColor = ConsoleColor.Blue;

      // Write app info
      Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

      // Change console text color back
      Console.ResetColor();
    }

    static void GreetUser() {
      // Ask user for their name
      Console.WriteLine("What is your name?");

      // Get user input
      string userName = Console.ReadLine();

      Console.WriteLine($"Hello, {userName}! Let's play a game!");
    }

    static void PrintColorMessage(ConsoleColor color, string message) {
      // Change text color
      Console.ForegroundColor = color;

      // Tell user it's not a number
      Console.WriteLine(message);

      // Change console text color back
      Console.ResetColor();
    }
  }
}
