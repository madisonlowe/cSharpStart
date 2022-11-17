// Hello C#
// See: https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/

string greeting = "     Hello World!      ";
string startTrimmed = greeting.TrimStart();
string endTrimmed = greeting.TrimEnd();
string smartTrimmed = greeting.Trim();

Console.WriteLine($"[{greeting}]");
Console.WriteLine($"[{startTrimmed}]");
Console.WriteLine($"[{endTrimmed}]");
Console.WriteLine($"[{smartTrimmed}]");
Console.WriteLine($"[{greeting}]");

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songLyrics = "You say goodbye, and I say hello";

Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));
// Above returns boolean check. Sensitive to punctuation.
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.EndsWith("greetings"));