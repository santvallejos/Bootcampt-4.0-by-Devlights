namespace CollectionsExercises;

/// <summary>
/// Bootcamp 4.0 - Collections Exercises
/// This project demonstrates working with various collection types in C#
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Bootcamp 4.0 - Collections Exercises ===\n");

        // Exercise 1: Lists
        Exercise1_Lists();

        // Exercise 2: Dictionaries
        Exercise2_Dictionaries();

        // Exercise 3: Sets
        Exercise3_Sets();

        // Exercise 4: Queues and Stacks
        Exercise4_QueuesAndStacks();

        Console.WriteLine("\n=== All Collections Exercises Completed! ===");
    }

    static void Exercise1_Lists()
    {
        Console.WriteLine("--- Exercise 1: Lists ---");
        
        // Create and populate a list
        List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };
        
        // Add elements
        fruits.Add("Grape");
        fruits.Add("Mango");
        
        Console.WriteLine($"Total fruits: {fruits.Count}");
        Console.WriteLine("Fruits:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine($"  - {fruit}");
        }
        
        // Remove an element
        fruits.Remove("Banana");
        Console.WriteLine($"After removing Banana: {string.Join(", ", fruits)}");
        
        // Check if element exists
        bool hasApple = fruits.Contains("Apple");
        Console.WriteLine($"Contains Apple? {hasApple}");
        
        // Sort the list
        fruits.Sort();
        Console.WriteLine($"Sorted: {string.Join(", ", fruits)}\n");
    }

    static void Exercise2_Dictionaries()
    {
        Console.WriteLine("--- Exercise 2: Dictionaries ---");
        
        // Create a dictionary
        Dictionary<string, int> studentGrades = new Dictionary<string, int>
        {
            { "Alice", 95 },
            { "Bob", 87 },
            { "Carol", 92 }
        };
        
        // Add new entries
        studentGrades["David"] = 88;
        studentGrades["Eve"] = 90;
        
        Console.WriteLine("Student Grades:");
        foreach (var kvp in studentGrades)
        {
            Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
        }
        
        // Access specific value
        Console.WriteLine($"\nBob's grade: {studentGrades["Bob"]}");
        
        // Check if key exists
        if (studentGrades.ContainsKey("Alice"))
        {
            Console.WriteLine($"Alice's grade: {studentGrades["Alice"]}");
        }
        
        // Update a value
        studentGrades["Bob"] = 90;
        Console.WriteLine($"Bob's updated grade: {studentGrades["Bob"]}\n");
    }

    static void Exercise3_Sets()
    {
        Console.WriteLine("--- Exercise 3: Sets (HashSet) ---");
        
        // Create hash sets
        HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };
        
        Console.WriteLine($"Set A: {string.Join(", ", setA)}");
        Console.WriteLine($"Set B: {string.Join(", ", setB)}");
        
        // Union
        var union = new HashSet<int>(setA);
        union.UnionWith(setB);
        Console.WriteLine($"Union: {string.Join(", ", union)}");
        
        // Intersection
        var intersection = new HashSet<int>(setA);
        intersection.IntersectWith(setB);
        Console.WriteLine($"Intersection: {string.Join(", ", intersection)}");
        
        // Difference
        var difference = new HashSet<int>(setA);
        difference.ExceptWith(setB);
        Console.WriteLine($"Difference (A - B): {string.Join(", ", difference)}");
        
        // Add element (duplicates are ignored)
        setA.Add(3); // Already exists
        setA.Add(6); // New element
        Console.WriteLine($"Set A after adding 3 and 6: {string.Join(", ", setA)}\n");
    }

    static void Exercise4_QueuesAndStacks()
    {
        Console.WriteLine("--- Exercise 4: Queues and Stacks ---");
        
        // Queue (FIFO - First In, First Out)
        Console.WriteLine("Queue Example:");
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");
        
        Console.WriteLine($"Queue contents: {string.Join(", ", queue)}");
        Console.WriteLine($"Dequeue: {queue.Dequeue()}"); // Removes "First"
        Console.WriteLine($"Peek: {queue.Peek()}"); // Shows "Second" without removing
        Console.WriteLine($"Remaining: {string.Join(", ", queue)}");
        
        Console.WriteLine();
        
        // Stack (LIFO - Last In, First Out)
        Console.WriteLine("Stack Example:");
        Stack<string> stack = new Stack<string>();
        stack.Push("Bottom");
        stack.Push("Middle");
        stack.Push("Top");
        
        Console.WriteLine($"Stack contents: {string.Join(", ", stack)}");
        Console.WriteLine($"Pop: {stack.Pop()}"); // Removes "Top"
        Console.WriteLine($"Peek: {stack.Peek()}"); // Shows "Middle" without removing
        Console.WriteLine($"Remaining: {string.Join(", ", stack)}\n");
    }
}
