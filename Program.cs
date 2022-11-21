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
        Console.WriteLine($"The username has been set as {username}");
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