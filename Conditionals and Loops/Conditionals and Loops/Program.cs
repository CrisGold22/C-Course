Console.WriteLine("Conditionals and Loops");
Console.WriteLine("=====================================");
Console.WriteLine("Enter your age:");
string age = Console.ReadLine();
int ageInt = int.Parse(age);

//Logic Operators
// Logical AND (&&)
// Logical OR (||)
// Logical NOT (!)

// Conditional Syntax
if (ageInt > 18)
{
    Console.WriteLine("You are an adult.");
}
else if (ageInt == 18)
{
    Console.WriteLine("You are just an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}

// Using an Ternary Operator
string result = (ageInt > 18) ? "You are an adult." : "You are a minor.";
Console.WriteLine(result);

// Using a Switch Statement
Console.WriteLine("Enter a numbet between 1 and 12 (it represents the months):");
string month = Console.ReadLine();
int monthInt = int.Parse(month);

switch (monthInt)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
    case 8:
        Console.WriteLine("August");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10:
        Console.WriteLine("October");
        break;
    case 11:
        Console.WriteLine("November");
        break;
    case 12:
        Console.WriteLine("December");
        break;
    default:
        Console.WriteLine("Invalid month.");
        break;
}


// Loops Functions
// While Loop

int i = 0;
while (i < 5)
{
    Console.WriteLine("While Loop: " + i);
    i++;
}


// Do While Loop
int j = 0;
do
{
    Console.WriteLine("Do While Loop: " + j);
    j++;
} while (j < 5);

// For Loop

for (int k = 0; k < 5; k++)
{
    Console.WriteLine("For Loop: " + k);
}

// For Each Loop
string[] names = { "Alice", "Bob", "Charlie" };
foreach (string name in names)
{
    Console.WriteLine("For Each Loop: " + name);
}

// Break and Continue
// Break: Use to exit a loop
// Continue: Use to skip the current iteration and continue with the next one