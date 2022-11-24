Hello World programme for C# with notes:

```cs
using System;
// A 'using' directive that references the 'System' namespace.
// A namespace is a space where certain names have meaning. We can access things inside a namespace, like...

// 'Console' is a class on the System namespace.
// A class holds data and code that achieves particular outcomes. Classes are the basis of OOP.
class Hello // Class of 'Hello'.
{
    static void Main() // Method of 'Main' on class 'Hello'. Static method Main is conventional entry point to C# programmes.
    {
        Console.WriteLine("Hello World!"); // Programme output.
    } // Programme can use 'Console.WriteLine' as shorthand for 'System.Console.WriteLine' as we've accessed System.
}
```

- There is a convention that the name of the file which contains a particular class should match the class itself, in other words the program above should be held in a file called Hello.cs.
