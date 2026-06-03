# Builder Pattern - Laptop Configuration System in C#

## Overview

This project demonstrates the implementation of the **Builder Design Pattern** in C# using a simple **Laptop Configuration System**.

The Builder Pattern allows the construction of a complex object step by step. In this project, a Laptop object is configured gradually by setting its Processor and RAM through a LaptopBuilder class, and the final object is returned using the Build() method.

---

## Design Pattern Used

### Builder Pattern

The Builder Pattern is a **Creational Design Pattern** that separates the construction of an object from its representation, allowing the same construction process to create different configurations of an object.

Instead of creating an object with a large constructor containing many parameters, the Builder Pattern constructs the object step by step.

---

## Project Objective

The objectives of this project are:

- Understand the Builder Design Pattern
- Create objects step by step
- Improve code readability
- Avoid complex constructors with multiple parameters
- Demonstrate Object-Oriented Programming concepts

---

## Project Structure

```text
BuilderPatternLaptop
│
├── Laptop.cs
├── LaptopBuilder.cs
└── Program.cs
```

---

## Components

### Product

`Laptop`

Represents the object being built.

```csharp
public class Laptop
{
    public string Processor { get; set; }
    public int RAM { get; set; }
}
```

The Laptop class stores configuration details and provides a method to display them.

---

### Builder

`LaptopBuilder`

Responsible for constructing the Laptop object step by step.

Available methods:

- SetProcessor()
- SetRAM()
- Build()

Example:

```csharp
public LaptopBuilder SetProcessor(string processor)
{
    laptop.Processor = processor;
    return this;
}
```

Each method configures the Laptop and returns the builder object to support method chaining.

---

### Client

`Program.cs`

The client creates and configures the Laptop using the Builder.

```csharp
Laptop laptop = new LaptopBuilder()
                    .SetProcessor("Intel i5")
                    .SetRAM(8)
                    .Build();
```

---

## Workflow

1. Create a LaptopBuilder object.
2. Configure Laptop properties step by step.
3. Call Build() to create the final Laptop object.
4. Display the Laptop configuration.

---

## Sample Output

```text
Processor: Intel i5
RAM: 8 GB
```

---

## Benefits of Builder Pattern

### Step-by-Step Construction

The object is built gradually rather than through a large constructor.

### Improved Readability

Method chaining makes the code easy to read and understand.

### Easy Customization

Different Laptop configurations can be created using the same builder.

### Better Maintainability

New configuration options can be added easily without changing existing code.

---

## Technologies Used

- C#
- .NET
- Visual Studio

---

## How to Run

### Prerequisites

- Visual Studio
- .NET SDK

### Steps

1. Clone the repository

```bash
git clone <repository-url>
```

2. Open the project in Visual Studio

3. Build the solution

4. Run the application

```text
Ctrl + F5
```

---

## Key Concepts Demonstrated

- Builder Design Pattern
- Object-Oriented Programming
- Method Chaining
- Encapsulation
- Creational Design Patterns

---

## Future Enhancements

Possible improvements include:

- Add Storage configuration
- Add Graphics Card option
- Add Operating System selection
- Create Gaming Laptop and Office Laptop configurations

---

## Advantages

- Avoids telescoping constructors
- Improves code readability
- Supports step-by-step object creation
- Easy to extend with new configurations

---

## Conclusion

This project demonstrates the Builder Design Pattern by constructing a Laptop object step by step using a LaptopBuilder class. The pattern improves flexibility, readability, and maintainability while keeping object creation organized and simple.

---

## Author

Ganesh Chavan
