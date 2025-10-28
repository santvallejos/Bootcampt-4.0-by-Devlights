# LINQ Exercises

## Overview
This module introduces Language Integrated Query (LINQ), a powerful feature of C# that allows you to query and transform data in a declarative way.

## Learning Objectives
After completing these exercises, you will understand:
- Query syntax vs Method syntax
- Filtering data with Where
- Transforming data with Select
- Ordering data
- Aggregation operations
- Grouping and joining data

## Exercises

### Exercise 1: Basic LINQ Queries
Learn the fundamentals:
- Query syntax (SQL-like)
- Method syntax (fluent API)
- Filtering with `Where`
- Transformation with `Select`

**Examples:**
- Finding even/odd numbers
- Squaring numbers
- Query vs Method syntax comparison

### Exercise 2: Filtering and Ordering
Master data manipulation:
- Complex filtering conditions
- Ordering data ascending/descending
- Multiple ordering criteria

**Operations covered:**
- `Where()` with lambda expressions
- `OrderBy()`, `OrderByDescending()`
- `ThenBy()`, `ThenByDescending()`

### Exercise 3: Aggregation
Work with aggregation functions:
- Calculating sums and averages
- Finding minimum and maximum
- Counting elements
- Checking conditions with Any and All

**Operations covered:**
- `Sum()`, `Average()`
- `Min()`, `Max()`
- `Count()`, `Any()`, `All()`

### Exercise 4: Grouping and Joining
Advanced LINQ operations:
- Grouping data by criteria
- Performing calculations on groups
- Creating projections

**Operations covered:**
- `GroupBy()` for grouping
- `Select()` for projections
- Combining grouping with aggregation

## Running the Exercise
```bash
dotnet run --project src/04-LINQ/LINQExercises/LINQExercises.csproj
```

## Key Concepts

### Query Syntax
```csharp
var results = from item in collection
              where condition
              select item;
```

### Method Syntax
```csharp
var results = collection.Where(item => condition)
                        .Select(item => item);
```

## Next Steps
After mastering LINQ, move on to Async programming to learn how to write asynchronous code in C#.
