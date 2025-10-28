namespace AsyncExercises;

/// <summary>
/// Bootcamp 4.0 - Asynchronous Programming Exercises
/// This project demonstrates async/await patterns and Task-based asynchronous programming
/// </summary>
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== Bootcamp 4.0 - Async Programming Exercises ===\n");

        // Exercise 1: Basic Async/Await
        await Exercise1_BasicAsync();

        // Exercise 2: Multiple Async Tasks
        await Exercise2_MultipleAsyncTasks();

        // Exercise 3: Task.WhenAll and Task.WhenAny
        await Exercise3_TaskCombinators();

        // Exercise 4: Error Handling in Async
        await Exercise4_ErrorHandling();

        Console.WriteLine("\n=== All Async Exercises Completed! ===");
    }

    static async Task Exercise1_BasicAsync()
    {
        Console.WriteLine("--- Exercise 1: Basic Async/Await ---");
        
        Console.WriteLine("Starting async operation...");
        string result = await FetchDataAsync("User Data");
        Console.WriteLine($"Result: {result}");
        
        Console.WriteLine("Continuing after async operation...\n");
    }

    static async Task Exercise2_MultipleAsyncTasks()
    {
        Console.WriteLine("--- Exercise 2: Multiple Async Tasks ---");
        
        Console.WriteLine("Starting multiple async operations sequentially...");
        var watch = System.Diagnostics.Stopwatch.StartNew();
        
        string data1 = await FetchDataAsync("Data 1");
        string data2 = await FetchDataAsync("Data 2");
        string data3 = await FetchDataAsync("Data 3");
        
        watch.Stop();
        Console.WriteLine($"Sequential execution completed in {watch.ElapsedMilliseconds}ms");
        Console.WriteLine($"Results: {data1}, {data2}, {data3}\n");
    }

    static async Task Exercise3_TaskCombinators()
    {
        Console.WriteLine("--- Exercise 3: Task.WhenAll and Task.WhenAny ---");
        
        // Task.WhenAll - wait for all tasks to complete
        Console.WriteLine("Running tasks in parallel with Task.WhenAll...");
        var watch = System.Diagnostics.Stopwatch.StartNew();
        
        Task<string> task1 = FetchDataAsync("Data 1");
        Task<string> task2 = FetchDataAsync("Data 2");
        Task<string> task3 = FetchDataAsync("Data 3");
        
        string[] results = await Task.WhenAll(task1, task2, task3);
        
        watch.Stop();
        Console.WriteLine($"Parallel execution completed in {watch.ElapsedMilliseconds}ms");
        Console.WriteLine($"Results: {string.Join(", ", results)}");
        
        // Task.WhenAny - wait for first task to complete
        Console.WriteLine("\nRunning tasks with Task.WhenAny (first to complete)...");
        Task<string> taskA = FetchDataWithDelay("Fast Task", 500);
        Task<string> taskB = FetchDataWithDelay("Medium Task", 1000);
        Task<string> taskC = FetchDataWithDelay("Slow Task", 1500);
        
        Task<string> firstCompleted = await Task.WhenAny(taskA, taskB, taskC);
        Console.WriteLine($"First completed: {await firstCompleted}\n");
    }

    static async Task Exercise4_ErrorHandling()
    {
        Console.WriteLine("--- Exercise 4: Error Handling in Async ---");
        
        try
        {
            Console.WriteLine("Attempting async operation that will fail...");
            await FetchDataWithErrorAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught exception: {ex.Message}");
        }
        
        // Handling multiple task errors
        Console.WriteLine("\nHandling multiple async tasks with potential errors...");
        try
        {
            Task<string> task1 = FetchDataAsync("Valid Data");
            Task<string> task2 = FetchDataWithErrorAsync();
            
            await Task.WhenAll(task1, task2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"One or more tasks failed: {ex.Message}");
        }
        Console.WriteLine();
    }

    // Helper methods simulating async operations
    static async Task<string> FetchDataAsync(string dataName)
    {
        await Task.Delay(1000); // Simulate async operation
        return $"Fetched: {dataName}";
    }

    static async Task<string> FetchDataWithDelay(string dataName, int delayMs)
    {
        await Task.Delay(delayMs);
        return $"Fetched: {dataName}";
    }

    static async Task<string> FetchDataWithErrorAsync()
    {
        await Task.Delay(500);
        throw new InvalidOperationException("Simulated async error");
    }
}
