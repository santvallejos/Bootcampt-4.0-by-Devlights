namespace OOPExercises;

/// <summary>
/// Bootcamp 4.0 - Object-Oriented Programming Exercises
/// This project demonstrates OOP principles: Encapsulation, Inheritance, Polymorphism, and Abstraction
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Bootcamp 4.0 - OOP Exercises ===\n");

        // Exercise 1: Classes and Objects
        Exercise1_ClassesAndObjects();

        // Exercise 2: Inheritance
        Exercise2_Inheritance();

        // Exercise 3: Polymorphism
        Exercise3_Polymorphism();

        // Exercise 4: Interfaces
        Exercise4_Interfaces();

        Console.WriteLine("\n=== All OOP Exercises Completed! ===");
    }

    static void Exercise1_ClassesAndObjects()
    {
        Console.WriteLine("--- Exercise 1: Classes and Objects ---");
        
        var person = new Person("Alice", 28);
        person.DisplayInfo();
        person.Birthday();
        person.DisplayInfo();
        
        var bankAccount = new BankAccount("123456", 1000m);
        bankAccount.Deposit(500m);
        bankAccount.Withdraw(200m);
        Console.WriteLine($"Final Balance: ${bankAccount.GetBalance()}\n");
    }

    static void Exercise2_Inheritance()
    {
        Console.WriteLine("--- Exercise 2: Inheritance ---");
        
        var employee = new Employee("Bob", 35, "E001", 60000m);
        employee.DisplayInfo();
        employee.Work();
        
        var manager = new Manager("Carol", 42, "M001", 90000m, "Engineering");
        manager.DisplayInfo();
        manager.Work();
        manager.Manage();
        Console.WriteLine();
    }

    static void Exercise3_Polymorphism()
    {
        Console.WriteLine("--- Exercise 3: Polymorphism ---");
        
        Animal[] animals = new Animal[]
        {
            new Dog("Buddy"),
            new Cat("Whiskers"),
            new Bird("Tweety")
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Move();
        }
        Console.WriteLine();
    }

    static void Exercise4_Interfaces()
    {
        Console.WriteLine("--- Exercise 4: Interfaces ---");
        
        IShape[] shapes = new IShape[]
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 4)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name} - Area: {shape.CalculateArea():F2}, Perimeter: {shape.CalculatePerimeter():F2}");
        }
        Console.WriteLine();
    }
}

// Exercise 1: Basic Classes
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public void Birthday()
    {
        Age++;
        Console.WriteLine($"Happy Birthday {Name}! You are now {Age}!");
    }
}

class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew ${amount}. New balance: ${balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

// Exercise 2: Inheritance
class Employee : Person
{
    public string EmployeeId { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, int age, string employeeId, decimal salary)
        : base(name, age)
    {
        EmployeeId = employeeId;
        Salary = salary;
    }

    public virtual void Work()
    {
        Console.WriteLine($"{Name} is working...");
    }
}

class Manager : Employee
{
    public string Department { get; set; }

    public Manager(string name, int age, string employeeId, decimal salary, string department)
        : base(name, age, employeeId, salary)
    {
        Department = department;
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is managing the {Department} department...");
    }

    public void Manage()
    {
        Console.WriteLine($"{Name} is conducting team meetings and planning.");
    }
}

// Exercise 3: Polymorphism
abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void MakeSound();
    
    public virtual void Move()
    {
        Console.WriteLine($"{Name} is moving.");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof! Woof!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is running on four legs.");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow! Meow!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is gracefully walking.");
    }
}

class Bird : Animal
{
    public Bird(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Tweet! Tweet!");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} is flying in the sky.");
    }
}

// Exercise 4: Interfaces
interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength, double height)
    {
        Base = baseLength;
        Height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public double CalculatePerimeter()
    {
        // Simplified - assumes equilateral for perimeter calculation
        return 3 * Base;
    }
}
