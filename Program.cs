// See https://aka.ms/new-console-template for more information

using System;

// using System.Text.RegularExpressions;
class RPS 
{
    public static string SetUsername()
    {
        // string pattern = @"[a-zA-Z]";
        // Regex regex = new Regex(pattern);
        // CONDITION(?): Regex.IsMatch(username, regex)
        Console.WriteLine("Who is playing?");
        string? username = Console.ReadLine();
        while (string.IsNullOrEmpty(username) || !username.All(Char.IsLetter)) // Apparently this check quicker than RegEx?
        {
            Console.WriteLine("Try again! No spaces or numbers!");
            username = Console.ReadLine();
        }
        Console.WriteLine($"Hello {username[0].ToString().ToUpper() + username.Substring(1)}!\nType a number to make a selection.");
        return username;
    }

    public static bool SetWantsToPlay(ref bool wantsToPlay)
    {
        Console.WriteLine("Do you want to play again?\n1. True.\t2. False.");
        string? answer = Console.ReadLine();
        if (answer == "1")
        {
            return wantsToPlay = true; // Conventionally, camel case for variables.
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
            return wantsToPlay = false;
        }
    }

    public static string SetComputerMove(ref string computerMove)
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 4);

        switch (randomNumber)
        {
            case 1:
            return computerMove = "R";
            case 2:
            return computerMove = "P";
            case 3:
            return computerMove = "S";
            default:
            return computerMove = "computerMove error!";
        }
    }

    public static string SetPlayerMove(ref string playerMove)
    {
        Console.WriteLine("Your move!\n1. Rock.\t2. Paper.\t3. Scissors.");
        var chosenKey = Console.ReadLine();

        switch (chosenKey)
        {
            case "1":
            return playerMove = "R";
            case "2":
            return playerMove = "P";
            case "3":
            return playerMove = "S";
            default:
            return playerMove = "playerMove error!";
        }
    }

    public static void MoveCalculator(ref string playerMove, ref string computerMove)
    {
        switch ((playerMove, computerMove))
        {
            case ("R", "R"):
            Console.WriteLine("Draw!\nYou and Computer selected Rock.");
            break;
            case ("P", "P"):
            Console.WriteLine("Draw!\nYou and Computer selected Paper.");
            break;
            case ("S", "S"):
            Console.WriteLine("Draw!\nYou and Computer selected Scissors.");
            break;
            case ("R", "P"):
            Console.WriteLine("Computer wins!\nYou selected Rock, Computer selected Paper.");
            break;
            case ("R", "S"):
            Console.WriteLine("Player wins!\nYou selected Rock, Computer selected Scissors.");
            break;
            case ("P", "S"):
            Console.WriteLine("Computer wins!\nYou selected Paper, Computer selected Scissors.");
            break;
            case ("P", "R"):
            Console.WriteLine("Player wins!\nYou selected Paper, Computer selected Rock.");
            break;
            case ("S", "R"):
            Console.WriteLine("Computer wins!\nYou selected Scissors, Computer selected Rock.");
            break;
            case ("S", "P"):
            Console.WriteLine("Player wins!\nYou selected Scissors, Computer selected Paper.");
            break;
            default:
            Console.WriteLine("computerMove error!");
            break;
        }
    }

    static void Main()
    {
        SetUsername();

        bool wantsToPlay = true;
        string computerMove = "";
        string playerMove = "";

        while (wantsToPlay)
        {
            SetComputerMove(ref computerMove);
            SetPlayerMove(ref playerMove);
            // Apparently below check quicker than RegEx?
            if (!string.IsNullOrEmpty(playerMove) && !string.IsNullOrEmpty(computerMove))
            {
                MoveCalculator(ref playerMove, ref computerMove);
            }
            wantsToPlay = SetWantsToPlay(ref wantsToPlay);
        }
    } 
}

/*
TODO:
- Figure out RegEx.
- Add a counter.
- Google OOP - definitely making some wild choices here.
- https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes?source=recommendations
*/

// Console.BackgroundColor = ConsoleColor.Black;
// Console.ForegroundColor = ConsoleColor.Green;
// Can't use Beep() on Mac?

