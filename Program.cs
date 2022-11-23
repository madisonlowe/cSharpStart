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
        Console.WriteLine("Who's playing?");
        string? username = Console.ReadLine();
        while (string.IsNullOrEmpty(username) || !username.All(Char.IsLetter)) // Apparently this check quicker than RegEx?
        {
            Console.WriteLine("Try again! No spaces or numbers!");
            username = Console.ReadLine();
        }
        Console.WriteLine($"Hello {username[0].ToString().ToUpper() + username.Substring(1)}!");
        return username;
    }

    public static bool SetWantsToPlay(ref bool wantsToPlay)
    {
        Console.WriteLine("Do you want to play again? Please type true or false.");
        string? answer = Console.ReadLine();
        if (answer == "true")
        {
            return wantsToPlay = true;
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
        Console.WriteLine("Rock, paper, or scissors? Please type R, P, or S.");
        var chosenKey = Console.ReadLine();

        switch (chosenKey)
        {
            case "R":
            return playerMove = "R";
            case "P":
            return playerMove = "P";
            case "S":
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
            Console.WriteLine("Draw! You and Computer selected Rock.");
            break;
            case ("P", "P"):
            Console.WriteLine("Draw! You and Computer selected Paper");
            break;
            case ("S", "S"):
            Console.WriteLine("Draw! You and Computer selected Scissors.");
            break;
            case ("R", "P"):
            Console.WriteLine("Computer wins! You selected Rock, Computer selected Paper.");
            break;
            case ("R", "S"):
            Console.WriteLine("Player wins! You selected Rock, Computer selected Scissors.");
            break;
            case ("P", "S"):
            Console.WriteLine("Computer wins! You selected Paper, Computer selected Scissors.");
            break;
            case ("P", "R"):
            Console.WriteLine("Player wins! You selected Paper, Computer selected Rock.");
            break;
            case ("S", "R"):
            Console.WriteLine("Computer wins! You selected Scissors, Computer selected Rock.");
            break;
            case ("S", "P"):
            Console.WriteLine("Player wins! You selected Scissors, Computer selected Paper.");
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