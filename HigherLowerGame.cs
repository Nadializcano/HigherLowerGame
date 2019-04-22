using System;

class HigherLowerGame
{
  static void Main()
  {
    Console.WriteLine("Would you like to play the higher/lower game? (Y/N)");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      Start();
    }
    else
    {
      Console.WriteLine("See you next time");
    }
  }

  static void Start()
  {
    Console.WriteLine("Think of a number 1 - 100");
    Console.WriteLine("Is your number higher or lower than 50? (H/L/C as Correct)");
    string firstGuess = Console.ReadLine();
    if (firstGuess == "C" || firstGuess == "c")
    {
      Console.WriteLine("That is your number");
    }
    else if (firstGuess == "H" || firstGuess == "h")
    {
      Console.WriteLine("Is your number higher or lower than 75? H/L/C as Correct");
      string secondGuess = Console.ReadLine();
      if (secondGuess == "H" || secondGuess == "h")
      {
        Console.WriteLine("Is your number higher or lower than 88? (H/L/C)");
        string thirdGuess = Console.ReadLine();
        if (thirdGuess == "H" || thirdGuess == "h")
        {
          Console.WriteLine("Is your number higher or lower than 94? H/L/C");
          string fourthGuess = Console.ReadLine();
          if (fourthGuess == "H" || fourthGuess == "h")
          {
            Console.WriteLine("");
          }
        }
      }

    }


  }
}
