# C# Tuple Handling Example

This repository contains a simple example demonstrating how to use **Tuples** in C# for grouping related data and returning it from methods efficiently. The example shows how to deconstruct tuples and apply conditional logic in a clean, readable way.

## Features
- **Tuple Creation**: A method that returns a tuple with user data (ID, name, age).
- **Tuple Deconstruction**: Extracting tuple values using C# deconstruction syntax.
- **Conditional Logic**: Using a ternary operator to classify users as "Adult" or "Minor".

## Code Example

### TupleHandler.cs

```csharp
using System;

public class TupleHandler
{
    // Method to return a tuple containing user data
    public (int, string, int) GetUserData()
    {
        // Simulating data retrieval
        return (1, "Alice", 25);
    }

    // Method to display user data
    public void DisplayUserInfo((int number, string name, int age) userData)
    {
        var (number, name, age) = userData;
        string result = age >= 18 ? "Adult" : "Minor";
        Console.WriteLine($"User {name}, Age {age} - Status: {result}");
    }
}
