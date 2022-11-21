// See https://aka.ms/new-console-template for more information

using System;
// using System.Text.RegularExpressions;
class RockPaperScissors 
{
    public static string SetUsername()
    {
        // string pattern = @"[a-zA-Z]";
        // Regex regex = new Regex(pattern);
        // CONDITION(?): Regex.IsMatch(username, regex)
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();
        while (string.IsNullOrEmpty(username) || !username.All(Char.IsLetter)) // Apparently this check quicker than RegEx?
        {
            Console.WriteLine("Please enter a valid username!");
            Console.WriteLine("Enter username:");
            username = Console.ReadLine();
        }
        Console.WriteLine($"Hello {username[0].ToString().ToUpper() + username.Substring(1)}!");
        return username;
    }

    public static string SetComputerMove()
    {
        string computerMove;
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
            return computerMove = "Error";
        }
    }

    public static string SetPlayerMove()
    {
        string playerMove;
        
        Console.WriteLine("Rock, paper, or scissors? Please type R, P, or S.");
        var chosenKey = Console.ReadLine();

        switch (chosenKey)
        {
            case "R":
            Console.WriteLine("R was pressed.");
            return playerMove = "R";
            case "P":
            Console.WriteLine("P was pressed.");
            return playerMove = "P";
            case "S":
            Console.WriteLine("S was pressed.");
            return playerMove = "S";
            default:
            return playerMove = "Error";
            // default:
            // Console.WriteLine("Enter a valid key!");
            // break;
        }
    }

    static void Main()
    {
        string username = SetUsername();
        string playerMove = SetPlayerMove();
        string computerMove = SetComputerMove();

        switch ((playerMove, computerMove))
        {
            case (playerMove == computerMove):
            Console.WriteLine("Draw!");
            break;
            case ("R", "P"):
            Console.WriteLine("Computer wins!");
            break;
            case ("R", "S"):
            Console.WriteLine("Player wins!");
            break;
            case ("P", "S"):
            Console.WriteLine("Computer wins!");
            break;
            case ("P", "R"):
            Console.WriteLine("Player wins!");
            break;
            case ("S", "R"):
            Console.WriteLine("Computer wins!");
            break;
            case ("S", "P"):
            Console.WriteLine("Player wins!");
            break;
            default:
            Console.WriteLine("Error!");
            break;
        }
    } 
}

/*
TODO:
- Move tracker.
- If loops: if player types rock, paper or scissors, log this and roll the computer move
- Figure out RegEx.
*/

/*
while (!Console.KeyAvailable)
{
    Console.Beep();
}
NOTE: Can't use Beep() on my Mac? Googled and doesn't seem to have proper support.
*/

// Console.BackgroundColor = ConsoleColor.Black;
// Console.ForegroundColor = ConsoleColor.Green;