# Bootcamp 4.0 by Devlights

A comprehensive repository of exercises and activities focused on .NET development. This bootcamp covers fundamental to advanced concepts in C# and .NET programming.

## 📚 Table of Contents

- [Overview](#overview)
- [Prerequisites](#prerequisites)
- [Structure](#structure)
- [Getting Started](#getting-started)
- [Exercises](#exercises)
- [Running the Projects](#running-the-projects)
- [Learning Path](#learning-path)

## 🎯 Overview

This repository contains hands-on exercises designed to help you learn and practice .NET development. Each module focuses on specific concepts and includes working code examples that you can run, modify, and learn from.

## ⚙️ Prerequisites

Before you begin, ensure you have the following installed:

- [.NET SDK 8.0 or later](https://dotnet.microsoft.com/download)
- A code editor (recommended: [Visual Studio](https://visualstudio.microsoft.com/), [Visual Studio Code](https://code.visualstudio.com/), or [JetBrains Rider](https://www.jetbrains.com/rider/))
- Git (for cloning the repository)

To verify your .NET installation:
```bash
dotnet --version
```

## 📁 Structure

```
Bootcamp4.0/
├── src/
│   ├── 01-Fundamentals/          # Basic C# concepts
│   ├── 02-OOP/                   # Object-Oriented Programming
│   ├── 03-Collections/           # Working with Collections
│   ├── 04-LINQ/                  # Language Integrated Query
│   └── 05-Async/                 # Asynchronous Programming
├── Bootcamp4.0.sln              # Solution file
└── README.md                     # This file
```

## 🚀 Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/santvallejos/Bootcampt-4.0-by-Devlights.git
   cd Bootcampt-4.0-by-Devlights
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the solution**
   ```bash
   dotnet build
   ```

## 📖 Exercises

### 01 - Fundamentals
**Location:** `src/01-Fundamentals/Fundamentals/`

Learn the basics of C# programming:
- Variables and Data Types (int, string, bool, decimal, etc.)
- Control Flow (if/else, switch statements)
- Loops (for, while, foreach)
- Methods and return values

**Topics Covered:**
- Declaring and using variables
- Conditional logic
- Iteration patterns
- Function definitions

### 02 - Object-Oriented Programming (OOP)
**Location:** `src/02-OOP/OOPExercises/`

Master OOP principles in C#:
- Classes and Objects
- Encapsulation with properties
- Inheritance and base classes
- Polymorphism and method overriding
- Abstract classes
- Interfaces

**Topics Covered:**
- Creating and using classes
- Inheritance hierarchies
- Virtual and override methods
- Abstract classes vs Interfaces
- Real-world OOP examples

### 03 - Collections
**Location:** `src/03-Collections/CollectionsExercises/`

Work with various collection types:
- Lists (List<T>)
- Dictionaries (Dictionary<TKey, TValue>)
- Sets (HashSet<T>)
- Queues and Stacks

**Topics Covered:**
- Dynamic collections
- Key-value pairs
- Set operations (union, intersection, difference)
- FIFO and LIFO data structures

### 04 - LINQ
**Location:** `src/04-LINQ/LINQExercises/`

Learn Language Integrated Query:
- Query syntax vs Method syntax
- Filtering and ordering data
- Aggregation operations (Sum, Average, Count, etc.)
- Grouping and joining

**Topics Covered:**
- Where, Select, OrderBy
- Min, Max, Sum, Average
- GroupBy operations
- Complex queries

### 05 - Asynchronous Programming
**Location:** `src/05-Async/AsyncExercises/`

Master async/await patterns:
- Basic async/await syntax
- Multiple async tasks
- Task.WhenAll and Task.WhenAny
- Error handling in async code

**Topics Covered:**
- async and await keywords
- Task-based asynchronous pattern
- Parallel vs sequential execution
- Exception handling in async methods

## 🏃 Running the Projects

### Run a specific project:
```bash
# Fundamentals
dotnet run --project src/01-Fundamentals/Fundamentals/Fundamentals.csproj

# OOP Exercises
dotnet run --project src/02-OOP/OOPExercises/OOPExercises.csproj

# Collections
dotnet run --project src/03-Collections/CollectionsExercises/CollectionsExercises.csproj

# LINQ
dotnet run --project src/04-LINQ/LINQExercises/LINQExercises.csproj

# Async Programming
dotnet run --project src/05-Async/AsyncExercises/AsyncExercises.csproj
```

### Run all projects:
```bash
dotnet build
```

## 🎓 Learning Path

**Recommended order for beginners:**

1. **Start with Fundamentals** - Build a solid foundation in C# syntax and basic programming concepts
2. **Move to OOP** - Understand object-oriented design and how to structure your code
3. **Learn Collections** - Master data structures to organize and manipulate data efficiently
4. **Study LINQ** - Learn to query and transform data in a declarative way
5. **Explore Async** - Understand asynchronous programming for building responsive applications

## 💡 Tips for Learning

- **Run the code:** Execute each project to see the output
- **Modify the code:** Change values, add new examples, break things and fix them
- **Read the comments:** Each exercise includes explanatory comments
- **Experiment:** Try to solve similar problems on your own
- **Build projects:** Apply what you learn to create your own applications

## 🤝 Contributing

Feel free to suggest improvements, report issues, or add new exercises by opening an issue or pull request.

## 📄 License

This project is open source and available for educational purposes.

## 📞 Contact

For questions or feedback, please open an issue in this repository.

---

Happy coding! 🚀
