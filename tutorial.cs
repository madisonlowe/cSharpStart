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

// Numbers in C# 

// Order of operations is consistent with maths rules.
// Can use all usual mathematical operands.

// Integer division always produces integers, not decimals. It truncates the results.

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

// Int has max and min limits.
// If a calculation hits a limit, you get under or overflow.

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

// The double numeric type represents a double-precision floating point.
// Double precision numbers have twice the number of binary digits as single precision.
// On modern computers, double more common than single.
// Single precision numbers are declared using float.

// Seen integers and doubles. Third basic numeric type: decimal.
// Decimal has smaller range but greater precision than doubles.

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

// Above code shows greater precision of decimal type.
// The M symbol indicates that a constant should use decimal type. Otherwise, compiler assumes double.

// Branch and loop statements.

int intA = 5;
int intB = 3;

if (intA + intB > 10) // Can use multiple checks with && and || etc.
{
    Console.WriteLine($"{intA} plus {intB} is greater than 10.");
}
else 
{
    Console.WriteLine($"{intA} plus {intB} is not greater than 10.");
}

for(int counter = 0; counter < 10; counter++) // Eg. for(let i = 0; i < x.length; i++) in JS.
{
  Console.WriteLine($"Hello World! The counter is {counter}");
}

// Nested loops.
for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}

int total = 0;
for (int count = 1; count < 21; count++)
{
    if (count % 3 == 0)
    {
        total += count;
    }
}
Console.WriteLine(total);