namespace Fundamentals;

/// <summary>
/// Bootcamp 4.0 - Fundamentals Exercises
/// This project contains basic exercises to learn C# fundamentals
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Bootcamp 4.0 - Fundamentals Exercises ===\n");

        // Exercise 1: Variables and Data Types
        Exercise1_VariablesAndDataTypes();

        // Exercise 2: Control Flow (if/else, switch)
        Exercise2_ControlFlow();

        // Exercise 3: Loops
        Exercise3_Loops();

        // Exercise 4: Methods
        Exercise4_Methods();

        Console.WriteLine("\n=== All Fundamentals Exercises Completed! ===");
    }

    /// <summary>
    /// Exercise 1: Working with variables and different data types
    /// </summary>
    static void Exercise1_VariablesAndDataTypes()
    {
        Console.WriteLine("--- Exercise 1: Variables and Data Types ---");
        
        // Integer types
        int age = 25;
        long population = 7800000000L;
        
        // Floating-point types
        double price = 19.99;
        decimal salary = 50000.50m;
        
        // Character and string
        char grade = 'A';
        string name = "John Doe";
        
        // Boolean
        bool isActive = true;
        
        // Display results
        Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
        Console.WriteLine($"Price: ${price}, Salary: ${salary}");
        Console.WriteLine($"World Population: {population:N0}, Active: {isActive}");
        Console.WriteLine();
    }

    /// <summary>
    /// Exercise 2: Control flow statements
    /// </summary>
    static void Exercise2_ControlFlow()
    {
        Console.WriteLine("--- Exercise 2: Control Flow ---");
        
        int score = 85;
        
        // If-else statement
        if (score >= 90)
        {
            Console.WriteLine("Grade: A - Excellent!");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Grade: B - Very Good!");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Grade: C - Good");
        }
        else
        {
            Console.WriteLine("Grade: F - Needs Improvement");
        }
        
        // Switch statement
        string day = "Monday";
        switch (day)
        {
            case "Monday":
                Console.WriteLine("Start of the work week!");
                break;
            case "Friday":
                Console.WriteLine("Almost weekend!");
                break;
            case "Saturday":
            case "Sunday":
                Console.WriteLine("Weekend!");
                break;
            default:
                Console.WriteLine("Midweek day");
                break;
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Exercise 3: Different types of loops
    /// </summary>
    static void Exercise3_Loops()
    {
        Console.WriteLine("--- Exercise 3: Loops ---");
        
        // For loop
        Console.Write("For loop (1-5): ");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        
        // While loop
        Console.Write("While loop (countdown from 5): ");
        int count = 5;
        while (count > 0)
        {
            Console.Write($"{count} ");
            count--;
        }
        Console.WriteLine();
        
        // Foreach loop
        string[] fruits = { "Apple", "Banana", "Orange", "Grape" };
        Console.Write("Foreach loop (fruits): ");
        foreach (string fruit in fruits)
        {
            Console.Write($"{fruit} ");
        }
        Console.WriteLine("\n");
    }

    /// <summary>
    /// Exercise 4: Methods and return values
    /// </summary>
    static void Exercise4_Methods()
    {
        Console.WriteLine("--- Exercise 4: Methods ---");
        
        int sum = Add(10, 20);
        Console.WriteLine($"Sum of 10 + 20 = {sum}");
        
        int product = Multiply(5, 6);
        Console.WriteLine($"Product of 5 * 6 = {product}");
        
        string greeting = Greet("Alice");
        Console.WriteLine(greeting);
        
        bool isEven = IsEven(42);
        Console.WriteLine($"Is 42 even? {isEven}");
        Console.WriteLine();
    }

    // Helper methods for Exercise 4
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static string Greet(string name)
    {
        return $"Hello, {name}! Welcome to Bootcamp 4.0!";
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
