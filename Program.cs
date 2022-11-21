// See https://aka.ms/new-console-template for more information

// A 'using' directive references the 'System' namespace.
// Class of 'Hello'.
// Method of 'Main' on class 'Hello'. Static method Main is conventional entry point to C# programmes.
// 'Console' is a class on the System namespace. Can use 'Console.WriteLine' as shorthand for 'System.Console.WriteLine' as we've accessed System.

using System;
using System.Text.RegularExpressions;
class Hello 
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();

        // string pattern = @"[a-zA-Z]";
        // Regex regex = new Regex(pattern);
        // CONDITION(?): Regex.IsMatch(username, regex)

        while (string.IsNullOrEmpty(username) || !username.All(Char.IsLetter)) // Apparently this check quicker than RegEx?
        {
            Console.WriteLine("Please enter a valid username!");
            Console.WriteLine("Enter username:");
            username = Console.ReadLine();
        }

        Console.WriteLine($"Hello {username[0].ToString().ToUpper() + username.Substring(1)}!");
    } 
}

/*
TODO:
- Move tracker.
- If loops: if player types
- Figure out RegEx.
*/


