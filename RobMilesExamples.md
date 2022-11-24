Examples from C# Programming Yellow Book by Rob Miles, annotations from me.

Pg 14, 2.1.1.

A programme to calculate the amount of wood and glass needed to create a window.

- [Microsoft Learn docs on using directives.](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive)

```cs
using System; // A using directive, referencing the System namespace. In a namespace, particular names have meaning. It's an organisational structure for code that can contain classes and nested namespaces. Using directives on namespaces will not give you access to nested namespaces.

class GlazerCalc // A class of GlazerCalc. Conventionally, a file will be named after a particular class: so a file with just this class in would be called GlazerCalc.cs. Classes are the basis of OOP.
{
    static void Main() // Static keyword, in this context indicates that this method is statically a part of the enclosing class, and that it will always be where presently positioned. Void keyword, in this context indicates that Main() returns nothing. Keywords inform the compiler what should be the expected outcomes of our method. Conventionally, 'static void Main()' is the entry point to any given C# programme: when the programme is run, the first method given control is Main, and the programme will not run without it.
    {
        double width, height, woodLength, glassArea; // Double refers to a double precision floating point number. The listed variables will all be initialised as doubles.
        string widthString, heightString; // Listed variables initialised as strings.

        widthString = Console.ReadLine(); // ReadLine() is a method on the Console object. Assigns prompted, user-inputted text from the console to widthString.
        width = double.Parse(widthString); // Parse() is a method exposed by double. Parses numerical strings to doubles.

        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25; // The 3.25 is because the measurements for this need to be in feet.
        glassArea = 2 * ( width + height );

        Console.WriteLine($"The length of the wood is {woodLength} feet."); // WriteLine writes given string to the console.
        Console.WriteLine($"The area of the glass is {glassArea} square metres.");

    }
}
```
