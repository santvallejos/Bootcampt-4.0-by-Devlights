# Collections Exercises

## Overview
This module covers the essential collection types in C# and how to work with them effectively.

## Learning Objectives
After completing these exercises, you will understand:
- Different collection types and when to use them
- Working with Lists for dynamic arrays
- Using Dictionaries for key-value pairs
- HashSets for unique element collections
- Queues and Stacks for specialized data structures

## Exercises

### Exercise 1: Lists
Master dynamic collections:
- Creating and initializing lists
- Adding and removing elements
- Searching and sorting
- Iterating through lists

**Operations covered:**
- `Add()`, `Remove()`, `Contains()`
- `Sort()`, `Count`
- Foreach iteration

### Exercise 2: Dictionaries
Work with key-value pairs:
- Creating dictionaries
- Adding and accessing elements
- Checking for keys
- Updating values
- Iterating through key-value pairs

**Operations covered:**
- Indexer access `[key]`
- `ContainsKey()`, `ContainsValue()`
- `Add()` and updates

### Exercise 3: Sets (HashSet)
Understand unique collections:
- Creating hash sets
- Set operations (union, intersection, difference)
- Automatic duplicate removal

**Operations covered:**
- `UnionWith()`, `IntersectWith()`, `ExceptWith()`
- `Add()` with duplicate handling

### Exercise 4: Queues and Stacks
Learn specialized data structures:
- Queue (FIFO - First In, First Out)
- Stack (LIFO - Last In, First Out)
- When to use each structure

**Operations covered:**
- Queue: `Enqueue()`, `Dequeue()`, `Peek()`
- Stack: `Push()`, `Pop()`, `Peek()`

## Running the Exercise
```bash
dotnet run --project src/03-Collections/CollectionsExercises/CollectionsExercises.csproj
```

## Next Steps
After mastering collections, move on to LINQ to learn powerful query operations on collections.
