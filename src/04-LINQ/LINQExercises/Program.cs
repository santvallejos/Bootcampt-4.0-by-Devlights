namespace LINQExercises;

/// <summary>
/// Bootcamp 4.0 - LINQ Exercises
/// This project demonstrates Language Integrated Query (LINQ) operations
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Bootcamp 4.0 - LINQ Exercises ===\n");

        // Exercise 1: Basic LINQ Queries
        Exercise1_BasicQueries();

        // Exercise 2: Filtering and Ordering
        Exercise2_FilteringAndOrdering();

        // Exercise 3: Aggregation
        Exercise3_Aggregation();

        // Exercise 4: Grouping and Joining
        Exercise4_GroupingAndJoining();

        Console.WriteLine("\n=== All LINQ Exercises Completed! ===");
    }

    static void Exercise1_BasicQueries()
    {
        Console.WriteLine("--- Exercise 1: Basic LINQ Queries ---");
        
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Query syntax
        var evenNumbersQuery = from num in numbers
                              where num % 2 == 0
                              select num;
        
        Console.WriteLine($"Even numbers (Query syntax): {string.Join(", ", evenNumbersQuery)}");
        
        // Method syntax
        var oddNumbersMethod = numbers.Where(n => n % 2 != 0);
        Console.WriteLine($"Odd numbers (Method syntax): {string.Join(", ", oddNumbersMethod)}");
        
        // Select transformation
        var squares = numbers.Select(n => n * n);
        Console.WriteLine($"Squares: {string.Join(", ", squares)}\n");
    }

    static void Exercise2_FilteringAndOrdering()
    {
        Console.WriteLine("--- Exercise 2: Filtering and Ordering ---");
        
        var students = new List<Student>
        {
            new Student { Name = "Alice", Age = 20, Grade = 85 },
            new Student { Name = "Bob", Age = 22, Grade = 92 },
            new Student { Name = "Carol", Age = 19, Grade = 78 },
            new Student { Name = "David", Age = 21, Grade = 88 },
            new Student { Name = "Eve", Age = 20, Grade = 95 }
        };
        
        // Filter students with grade >= 85
        var topStudents = students.Where(s => s.Grade >= 85);
        Console.WriteLine("Students with grade >= 85:");
        foreach (var student in topStudents)
        {
            Console.WriteLine($"  {student.Name}: {student.Grade}");
        }
        
        // Order by grade descending
        var orderedByGrade = students.OrderByDescending(s => s.Grade);
        Console.WriteLine("\nStudents ordered by grade (descending):");
        foreach (var student in orderedByGrade)
        {
            Console.WriteLine($"  {student.Name}: {student.Grade}");
        }
        
        // Multiple ordering
        var orderedMultiple = students.OrderBy(s => s.Age).ThenByDescending(s => s.Grade);
        Console.WriteLine("\nStudents ordered by age, then by grade:");
        foreach (var student in orderedMultiple)
        {
            Console.WriteLine($"  {student.Name} - Age: {student.Age}, Grade: {student.Grade}");
        }
        Console.WriteLine();
    }

    static void Exercise3_Aggregation()
    {
        Console.WriteLine("--- Exercise 3: Aggregation ---");
        
        int[] numbers = { 10, 20, 30, 40, 50 };
        
        // Sum
        int sum = numbers.Sum();
        Console.WriteLine($"Sum: {sum}");
        
        // Average
        double average = numbers.Average();
        Console.WriteLine($"Average: {average}");
        
        // Min and Max
        int min = numbers.Min();
        int max = numbers.Max();
        Console.WriteLine($"Min: {min}, Max: {max}");
        
        // Count
        int count = numbers.Count(n => n > 25);
        Console.WriteLine($"Count of numbers > 25: {count}");
        
        // Any and All
        bool hasLargeNumber = numbers.Any(n => n > 40);
        bool allPositive = numbers.All(n => n > 0);
        Console.WriteLine($"Has number > 40? {hasLargeNumber}");
        Console.WriteLine($"All numbers positive? {allPositive}\n");
    }

    static void Exercise4_GroupingAndJoining()
    {
        Console.WriteLine("--- Exercise 4: Grouping and Joining ---");
        
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200 },
            new Product { Id = 2, Name = "Mouse", Category = "Electronics", Price = 25 },
            new Product { Id = 3, Name = "Desk", Category = "Furniture", Price = 300 },
            new Product { Id = 4, Name = "Chair", Category = "Furniture", Price = 150 },
            new Product { Id = 5, Name = "Keyboard", Category = "Electronics", Price = 75 }
        };
        
        // Grouping
        var groupedByCategory = products.GroupBy(p => p.Category);
        Console.WriteLine("Products grouped by category:");
        foreach (var group in groupedByCategory)
        {
            Console.WriteLine($"\n{group.Key}:");
            foreach (var product in group)
            {
                Console.WriteLine($"  - {product.Name}: ${product.Price}");
            }
        }
        
        // Grouping with aggregation
        Console.WriteLine("\nAverage price per category:");
        var avgPriceByCategory = products.GroupBy(p => p.Category)
                                        .Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.Price) });
        foreach (var item in avgPriceByCategory)
        {
            Console.WriteLine($"  {item.Category}: ${item.AvgPrice:F2}");
        }
        Console.WriteLine();
    }
}

// Supporting classes
class Student
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public int Grade { get; set; }
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
