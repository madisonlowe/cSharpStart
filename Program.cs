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

    static void Main()
    {
        string username = SetUsername();
        string playerMove;
        
        Console.WriteLine("Rock, paper, or scissors? Please type R, P, or S.");
        var chosenKey = Console.ReadLine();

        switch (chosenKey)
        {
            case "R":
            playerMove = "R";
            Console.WriteLine("R was pressed.");
            break;
            case "P":
            playerMove = "P";
            Console.WriteLine("P was pressed.");
            break;
            case "S":
            playerMove = "S";
            Console.WriteLine("S was pressed.");
            break;
            default:
            Console.WriteLine("Enter a valid key!");
            break;
        }

        Random rnd = new Random();
        int computerMove = rnd.Next(1, 4);
        Console.WriteLine(computerMove);
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