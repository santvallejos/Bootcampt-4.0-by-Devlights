# Asynchronous Programming Exercises

## Overview
This module covers asynchronous programming in C# using the async/await pattern, which is essential for building responsive and scalable applications.

## Learning Objectives
After completing these exercises, you will understand:
- The async and await keywords
- Task-based asynchronous programming
- Running tasks in parallel vs sequentially
- Combining multiple async operations
- Error handling in async code

## Exercises

### Exercise 1: Basic Async/Await
Learn the fundamentals:
- Using the `async` keyword
- Using the `await` keyword
- Understanding Task<T>
- Async method flow

**Concepts:**
- Asynchronous method execution
- Non-blocking operations
- Task completion

### Exercise 2: Multiple Async Tasks
Understand execution patterns:
- Sequential async execution
- Performance implications
- Measuring execution time

**Key Learning:**
- Sequential tasks complete one after another
- Total time is the sum of all tasks

### Exercise 3: Task Combinators
Master parallel execution:
- `Task.WhenAll()` - wait for all tasks
- `Task.WhenAny()` - wait for first task
- Parallel execution benefits

**Operations covered:**
- Running tasks in parallel
- Performance improvements
- Coordinating multiple operations

### Exercise 4: Error Handling
Learn to handle async errors:
- Try-catch with async/await
- Handling multiple task errors
- Exception propagation in async code

**Concepts:**
- Async exception handling
- Task.WhenAll error behavior
- Best practices for error handling

## Running the Exercise
```bash
dotnet run --project src/05-Async/AsyncExercises/AsyncExercises.csproj
```

## Key Concepts

### Async Method Signature
```csharp
public async Task<string> FetchDataAsync()
{
    await Task.Delay(1000);
    return "Data";
}
```

### Calling Async Methods
```csharp
string result = await FetchDataAsync();
```

### Parallel Execution
```csharp
var task1 = FetchData1Async();
var task2 = FetchData2Async();
await Task.WhenAll(task1, task2);
```

## Best Practices
- Always use async/await for I/O operations
- Don't block on async code (avoid `.Result` or `.Wait()`)
- Use `Task.WhenAll()` for parallel operations
- Always handle exceptions in async code
- Name async methods with "Async" suffix

## Real-World Applications
Async programming is crucial for:
- Web API calls
- Database operations
- File I/O
- Network operations
- UI applications (keeping UI responsive)

## Next Steps
With these foundational skills, you're ready to build real .NET applications! Consider exploring:
- ASP.NET Core for web development
- Entity Framework Core for database access
- Dependency Injection patterns
- Unit testing with xUnit or NUnit
