# Notes from C# Programming Yellow Book (2019 edn.) by Rob Miles.

Please refer to [Rob Miles' website](http://www.csharpcourse.com) for further resources and information!

## Examples.

### Pg. 14, 2.1.1.

A programme to calculate the amount of wood and glass needed to create a window.

- [Microsoft Learn docs on using directives.](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive)

```cs
using System;
/* A using directive, referencing the System namespace.
In a namespace, particular names have meaning.
It's an organisational structure for code that can contain classes and nested namespaces.
Using directives on namespaces will not give you access to nested namespaces. */

class GlazerCalc
/* A class of GlazerCalc.
Conventionally, a file will be named after a particular class: so, a file with this class in would be called GlazerCalc.cs.
Classes are the basis of OOP. */
{
    static void Main()
    /* Static keyword, in this context indicates that this method is statically a part of the enclosing class, and that it will always be where presently positioned.
    Void keyword, in this context indicates that Main() returns nothing.
    Keywords inform the compiler what should be the expected outcomes of our method.
    Conventionally, 'static void Main()' is the entry point to any given C# programme.
    When the programme runs, the first method given control is Main, and the programme will not run without it. */
    {
        double width, height, woodLength, glassArea; // Double refers to a double precision floating point number.
        string widthString, heightString; // Listed variables all declared and initialised as strings.

        widthString = Console.ReadLine(); // ReadLine() is a method on the Console object. Assigns user input to variable.
        width = double.Parse(widthString); // Parse() is a method exposed by double. Parses numerical strings to doubles.

        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25; // The 3.25 is because the measurements for this need to be in feet.
        glassArea = 2 * ( width + height );

        Console.WriteLine($"The length of the wood is {woodLength} feet."); // WriteLine() writes given string to the console.
        Console.WriteLine($"The area of the glass is {glassArea} square metres.");

    }
}
```

### Pg. 38, 2.3.2.

Previous example, reloaded:

```cs
using System;

class GlazerCalc
{
    static void Main()
    {
        double width, height, woodLength, glassArea;
        // To avoid using magic numbers - unexplained, direct use of number in programme - declare measurement consts here.
        // Conventionally, constants declared in all caps.
        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;
        const double MAX_HEIGHT = 3.0;
        const double MIN_NEIGHT = 0.75;

        string widthString, heightString;

        Console.Write("Give the width of the window: ");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);
        // Added If statements cover some errors.
        // Not well, though: exceeding values results in  MAX or MIN value being used in place of correct value.
        // Needs loops.
        if (width < MIN_WIDTH) {
            Console.WriteLine("Width is too small.\n\n");
            Console.WriteLine("Using minimum.");
            width = MIN_WIDTH;
        }

        if (width > MAX_WIDTH) {
            Console.WriteLine("Width is too large.\n\n");
            Console.WriteLine("Using maximum.");
            width = MAX_WIDTH;
        }

        Console.WriteLine("Give the height of the window: ");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        if (height < MIN_HEIGHT) {
            Console.WriteLine("Height is too small.\n\n");
            Console.WriteLine("Using minimum.");
            height = MIN_HEIGHT;
        }

        if (height > MAX_HEIGHT) {
            Console.WriteLine("Height is too large.\n\n");
            Console.WriteLine("Using maximum.");
            height = MAX_HEIGHT;
        }

        woodLength = 2 * ( width + height ) * 3.25;
        glassArea = 2 * ( width + height );

        Console.WriteLine($"The length of the wood is {woodLength} feet.");
        Console.WriteLine($"The area of the glass is {glassArea} square metres.");
    }
}

```

### Pg. 44, Complete Glazing Program.

Final version of previous examples, using all methods described up to this point.

```cs
using System;

class GlazerCalc
{
    static void Main()
    {
        double width, height, woodLength, glassArea;
        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;
        const double MAX_HEIGHT = 3.0;
        const double MIN_HEIGHT = 0.75;
        string widthString, heightString;

        do {
            Console.Write($"Give the width of the window between {MIN_WIDTH} and {MAX_WIDTH}:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
        } while (width < MIN_WIDTH || width > MAX_WIDTH); // Do-While runs at least once, then tests.

        do {
            Console.Write($"Give the height of the window between {MIN_HEIGHT} and {MAX_HEIGHT}:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
        } while (height < MIN_HEIGHT || height > MAX_HEIGHT); // While condition tests at end of block.

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        Console.WriteLine($"The length of the wood is {woodLength} feet.\nThe area of the glass is {glassArea} square metres.");
    }
}
```

## Notes

**1.1.2 Hardware and Software**

- Pg 3. "The Operating System makes the machine usable. It looks after all the information held on the computer and provides lots of commands to allow you to manage things. It also lets you run programs, ones you have written and ones from other people."
  - OS is the layer between applications and hardware. OS is a programme that, after being initially loaded into the computer by a boot programme, then manages all the other applications and programmes within the computer.
  - Applications can use the OS by requesting an API (application programme interface).

**1.1.3 Data and Information**

- Pg. 3. "Computers are data processors. Information is fed into them; they do something with it, and then generate further information [...] A program is unaware of the data it is processing in the same way that a sausage machine is unaware of what meat is. Put a bicycle into a sausage machine and it will try to make sausages out of it. Put invalid data into a computer and it will do equally useless things."
- Pg. 4. "As software engineers it is inevitable that a great deal of our time will be spent fitting data processing components into other devices to drive them. You will not press a switch to make something work, you will press a switch to tell a computer to make it work. These embedded systems will make computer users of everybody, and we will have to make sure that they are not even aware that there is a computer in there! [...] It is important that you remember your programs are actually executed by a piece of hardware which has physical limitations. You must make sure that the code you write will actually fit in the target machine and operate at a reasonable speed."

**1.2 Programs and Programming**

- Pg. 5. "Programming is defined by me as deriving and expressing a solution to a given problem in a form which a computer system can understand and execute."
- Pg. 5. "There are many things you must consider when writing a program; not all of them are directly related to the problem in hand [...] Before you solve a problem, you should make sure that you have a watertight definition of what the problem is, which both you and the customer agree on [...] In the real world such a definition is sometimes called a Functional Design Specification or FDS."
- Pg. 6. "You might think that this is not necessary if you are writing a program for yourself; there is no customer to satisfy. This is not true. Writing some form of specification forces you to think about your problem at a very detailed level. It also forces you to think about what your system is not going to do and sets the expectations of the customer right at the start."
- Pg. 6. "When considering how to write the specification of a system there are three important things: What information flows into the system. What flows out of the system. What the system does with the information."
- Pg. 7. "Information about information is called metadata."
- Pg. 8. "The test procedure which is designed for a proper project should test out all possible states within the program, including the all-important error conditions."
- Pg. 9. "One of the first things you must do is break down the idea of "I am writing a program for you" and replace it with "We are creating a solution to a problem". You do not work for your customers, you work with them."

**1.4 C#**

- Pg. 10. "A C# program can contain _managed_ or _unmanaged_ parts. The managed code is fussed over by the system which runs it. This makes sure that it is hard (but probably not impossible) to crash your computer running managed code. However, all this fussing comes at a price, causing your programs to run more slowly. To get the maximum possible performance, and enable direct access to parts of the underlying computer system, you can mark your programs as unmanaged. An unmanaged program goes faster, but if it crashes it is capable of taking the computer with it. Switching to unmanaged mode is analogous to removing the guard from your new chainsaw because it gets in the way."
  - This is interesting! Google later!
- Pg. 11. "A compiler is a very large program which knows how to decide if your program is legal. The first thing it does is check for errors in the way that you have used the language itself. Only if no errors are found by the compiler will it produce any output. The compiler will also flag up _warnings_ which occur when it notices that you have done something which is not technically illegal, but may indicate that you have made a mistake somewhere. An example of a warning situation is where you create something but don't use it for anything. The compiler would tell you about this, in case you had forgotten to add a bit of your program."
- Pg. 12. "Once you are sitting in front of the keyboard there is a great temptation to start pressing keys and typing something in which might work. This is not good technique. You will almost certainly end up with something which almost works, which you will then spend hours fiddling with to get it going. If you had sat down with a pencil and worked out the solution first you would probably get to a working system in around half the time."

**1.4.6 What Comprises a C# Program?**

- Pg. 12. "The C# compiler needs to know certain things about your program. It needs to know which external resources your program is going to use. It also can be told about any options for the construction of your program which are important. Some parts of your program will simply provide this information to tell the compiler what to do."
- Pg. 12. "A variable is simply a named location in which a value is held whilst the program runs. C# also lets you build up structures which can hold more than one item, for example a single structure could hold all the information about a particular bank customer."
- Pg. 13. "A single, simple, instruction to do something in a C# program is called a statement. A statement is an instruction to perform one particular operation, for example add two numbers together and store the result [...] In the case of C# you can lump statements together to form a lump of program which does one particular task. Such a lump is called a method. A method can be very small, or very large."
- Pg. 13. "You give a name to each method that you create, and you try to make the name of the function fit what it does, for example `ShowMenu` or `SaveToFile`. The C# language actually runs your program by looking for a method with a special name, `Main`. This method is called when your program starts running, and when `Main` finishes, your program ends. The names that you invent to identify things are called _identifiers_."
- Pg. 17. "All statements in C# programs are separated by the ; character, this helps to keep the compiler on the right track."
  - Think about syntax same way you think about grammatical structure, maybe try and learn it the same way too? Process of pattern learning and pattern matching, contains knowledge in its structure. Do they do books on programming grammar?

_See: First example. Pg. 14, 2.1.1._

**2.2 Manipulating Data**

- Pg. 22. "When considering numeric values there are two kinds of data: Nice chunky individual values, for example the number of sheep in a field, teeth on a cog, apples in a basket. These are referred to as _integers_. Nasty real world type things, for example the current temperature, the length of a piece of string, the speed of a car. These are referred to as _reals_."
- Pg. 22. "In the first case [of integers] we can hold the value exactly; you always have an exact number of these items, they are _integral_."
- Pg. 22. "In the second case we can never hold what we are looking at exactly. Even if you measure a piece of string to 100 decimal places it is still not going to give you its exact length - you could always get the value more accurately. These are _real_. A computer is digital, i.e. it operates entirely on patterns of bits which can be regarded as numbers. Because we know that it works in terms of ons and offs it has problems holding real values. To handle real values the computer actually stores them to a limited accuracy, which we hope is adequate (and usually is)."
- Pg. 22. "When you are writing a specification you should worry about the precision to which values are to be held. Too much accuracy may slow the machine down - too little may result in the wrong values being used."
  - You can store integers in a load of different types in C#, including: sbyte, byte, short, ushort, int, uint, long, ulong and char. They all have different ranges and bit sizes.
- Pg. 23. "Something else which you should bear in mind is that a program will not always detect when you exceed the range of a variable. If I put the value 255 into a variable of type byte this is OK, because 255 is the biggest possible value of the type can hold. However, if I add one to the value in this variable the system may not detect this as an error. In fact this may cause the value to 'wrap round' to 0."
  - Why on earth does it do this?

_Storing real values_

- Pg. 24. "'Real' is a generic term for numbers which are not integers. They have a decimal point and a fractional part. Depending on the value the decimal point floats around in the number, hence the name `float`."
- Pg. 24. "A standard `float` value has a range of 1.5E-45 to 3.4E48 with a precision of only 7 digits (i.e. not as good as most pocket calculators). If you want more precision (although of course your programs will use up more computer memory and run more slowly) you can use a double box instead (double is an abbreviation for double precision). This takes up more computer memory but it has a range of 5.0E-324 to 1.7E308 and a precision of 15 digits."
- Pg. 24. "There are two ways in which you can store floating point numbers; as float or as double. When it comes to putting literal values into the program itself the compiler likes to know if you are writing a floating point value (smaller sized box) or double precision (larger sized box)."
- Pg. 24. "Unlike the way that integers work, with real numbers the compiler is quite fussy about how they can and can't be combined. This is because when you move a value from a double precision variable into an ordinary floating point variable some of the precision is lost. This means that you have to take special steps to make sure that you as a programmer make clear that you want this to happen and that you can live with the consequences. This process is known as casting and we will consider it in detail a bit later."
- Pg. 25. "You will find that I, and most programmers, tend to use just integers (int) and floating point (float) variable types."

**2.2.3 Storing Text**

- Pg. 25. "Sometimes the information we want to store is text. This can be in the form of a single character; at other times it will be a string [...] A char is a type of variable which can hold a single character."

| Character | Escape Squence Name |
| --------- | ------------------- |
| \'        | Single quote        |
| \"        | Double quote        |
| \\        | Backslash           |
| \0        | Null                |
| \a        | Alert               |
| \b        | Backspace           |
| \f        | Form feed           |
| \n        | New line            |
| \r        | Carriage return     |
| \t        | Horizontal tab      |
| \v        | Vertical quote      |

- Pg. 26. "A string literal value is expressed enclosed in double quotes [...] The string can contain the escape sequences above [...] If I am just expressing text with no escape characters or anything strange I can tell the compiler that this is a verbatim string. I do this by putting an @ in front of the literal: `@"\x0041BCDE\a"` [...] This can be useful when you are expressing things like file paths."

** 2.2.4 Storing State Using Booleans **

- Pg. 27. "Also when considering how to store data it is important to remember where it comes from [...] This illustrates another metadata consideration, when you are given the prospect of storing floating point information; find out how it is being produced before you decide how it will be stored. As an example, you might think that being asked to work with the speed of a car you would have to store a floating point value. However, when you find out that the speed sensor only gives answers to an accuracy of 1 mile per hour, this makes the job much simpler."

**2.2.6 Giving Values to Variables**

- Pg. 29. "When C# works out an expression it looks along it for all the operators with the highest priority and does them first. It then looks for the next ones down and so on until the final result is obtained."
  - On pg. 29, there is a very useful chart of operators in order of their precedence. I have copied Rob's chart below for reference. However, I am bad at maths and will simply be circumventing this issue by putting brackets on everything, however.

| Operator | What It Does                                                                                                      |
| -------- | ----------------------------------------------------------------------------------------------------------------- |
| -        | Unary minus, the minus that C# finds in negative numbers, e.g. -1. Unary means applying to only one item.         |
| \*       | Multiplication, note the use of the \* rather than the more mathematically correct but confusing x.               |
| /        | Division, because of the difficulty of drawing one number above another on a screen we use this character instead |
| +        | Addition.                                                                                                         |
| -        | Subtraction. Note that we use exactly the same character as for unary minus.                                      |

**2.2.7 Changing the Type of Data**

- Pg. 29-30. "Whenever I move a value from one type to another the C# compiler gets very interested in what I am doing. It worries about whether or not the operation I'm about to perform will cause data to be lost from the program. It considers every operation in terms of 'widening and narrowing' values."

_Widening and Narrowing_

- Pg. 30. "The general principle which C# uses is that if you are 'narrowing' a value it will always ask you to explicitly tell it that this is what you want to do. If you are widening there is no problem."
- Pg. 30. "To understand what we mean by these terms we could consider suitcases. If I am packing for a trip I will take a case. If I decide to switch to a smaller case I will have to take everything out of the large case and put it into the smaller one. But it might not have room, so I have to leave behind one of my shirts. This is 'narrowing'."
- Pg. 30. "However, if I change to a bigger case there is no problem. The bigger case will take everything that was in the smaller case and have room for more."

_Casting_

- Pg. 30. "We can force C# to regard a value as being of a certain type by the use of casting. A cast takes the form of an additional instruction to the compiler to force it to regard a value in a particular way. You cast a value by putting the type you want to see there in brackets before it." Example:

```cs
double d = 1.5;
float f = (float) d ;
```

- Pg. 30. "You can regard casting as the compiler's way of washing its hands of the problem. If a program fails because data is lost it is not because the compiler did something silly."
- Pg. 30. "As we saw above, each type of variable has a particular range of possible values, and the range of floating point values is much greater than that for integers [...] It is up to you when you write your program to make sure that you never exceed the range of the data types you are using - the program will not notice but the user certainly will!"
- Pg. 31. "A cast can also lose information in other ways [...] You should remember that [...] truncation takes place whenever you cast from a value with a fractional part (float, double, decimal) into one without." Eg. if you cast a fraction to an integer, it will discard the fractional part or any decimals, and you'll lose that accuracy and value.
- Pg. 32. "If you want complete control over the particular kind of operator the compiler will generate for you the program must contain explicit casts to set the correct context for the operator."

**2.3 Writing a Program**

- Pg. 33. "I think that while it is not a story as such, a good program text does have some of the characteristics of good literature: It should be easy to read. At no point should the hapless reader be forced to backtrack or brush up on knowledge that the writer assumes is there. All the names in the text should impart meaning and be distinct from each other. It should have good punctuation and grammar [...] It should look good on the page. A good program is well laid out [...] It should be clear who wrote it, and when it was last changed."
- Pg. 34. "Basically there are three types of program flow: 1. straight line, 2. chosen depending on a given condition, 3. repeated according to a given condition."
- Pg. 35. "To make conditions work for us we need a set of additional relational operators which we can use in logical expressions. Relational operators work on operands, just like numeric ones. However any expression involving them can only produce one of two values, `true` or `false`."
- Pg. 36. "Note that it is not particularly meaningful to compare floating point variables to see if they hold exactly the same values. Because of the fact that they are held to limited precision you might find that conditions fail when they should not for example the following equation: `x = 3.0 * (1.0 / 3.0);` - may well result in x containing 0.99999999, which would mean that: `x == 1.0` - would be false - even though mathematically the test should evaluate to `true`."

**2.3.3 Loops**

```cs
// Do-While Loop.
// Performs at least once, even if the while statement won't pass: the test for the while condition is performed after the code is run in the rest of the statement.
using System;

class InfiniteDoWhileLoop
{
    public static void Main()
    {
        do
            Console.WriteLine("Hello World");
        while (true);
    }
}
```

```cs
// While Loop.
// While condition comes first, so the code only runs if while is met.
using System;

class InfiniteWhileLoop
{
    public static void Main()
    {
        int i;
        i = 1;
        while ( i = 1)
        {
            Console.WriteLine("Hello World");
        }
    }
}
```

```cs
// For Loop.
// When you want to repeat something X amount of times.
using System;

class ForLoop
{
    public static void Main()
    {
        int i;
        for ( i = 1; i < 11; i = i + 1)
        {
            Console.WriteLine("Hello World");
        }
    }
}
```

- Pg. 42. "Writing a loop in this way [for loop] is quicker and simpler than using a form of `while` because it keeps all the elements of the loop in one place instead of leaving them spread about the program. This means that you are less likely to forget to do something like give the control variable an initial value, or update it."
- Pg. 42. "Sometimes you may want to escape from a loop whilst you are in the middle of it [...] You can do this with the `break` statement. This is a command to leave the loop immediately. Your program would usually make some form of decision to quit in this way. [In the below example] Note that we are using two variables as switches, they do not hold values as such; they are actually used to represent states within the program as it runs. This is a standard programming trick that you will find very useful. You can break out of any of the three kinds of loop. In every case the program continues running at the statement after the last statement of the loop."

```cs
// Exemplary of above point, pg. 42.
while (runningOK)
{
    complex stuff
    ....
    if (aborted)
    {
        break ; }
    ....
    more complex stuff
    ....
}
....
bit we get to if aborted becomes true
....
```

- Pg. 43. "The `break` keyword smells a little like the dreaded `goto` statement, which programmers are often scared of. The `goto` is a special one that lets execution jump from one part of the program to another. For this reason the `goto` is condemned as a potentially dangerous and confusing device. The `break` statement lets you jump from any point in a loop to the statement just outside the loop. This means that if my program is at the statement immediately following the loop, there are a number of ways it could have got there; one for every break in the loop above. This can make the code harder to understand. The `break` construction is less confusing than the `goto`, but can still lead to problems. In this respect we advise you to exercise caution when using it."

  - Google this.

- Pg. 43. "Every now and then you will want to go back to the top of a loop and do it all again. This happens when you have gone as far down the statements as you need to. C# provides the `continue` keyword which says something along the lines of: Please do not go any further down this time round the loop. Go back to the top of the loop, do all the updating and stuff and go around if you are supposed to. [...] The `continue` causes the program to re-run the loop with the next value of item if it is OK to do so."

```cs
// Exemplary of above point, pg. 43.
for ( item = 1 ; item < Total_Items ; item=item+1 )
{
        .....
        item processing stuff
        ....
        if (Done_All_We_Need_This_Time) continue ;
        ....
        additional item processing stuff
        ....
}
```
