# Mars Rovers Kata

## Introduction

Welcome to the Mars Rovers Kata, a coding exercise designed to practice Test-Driven Development (TDD) using .NET. This kata simulates the movement of rovers on the surface of Mars. The requirements and detailed description of the kata can be found on the [Kata Catalog - Mars Rovers Kata](https://kata-log.rocks/mars-rover-kata).

## Project Highlights

- **Design Patterns**: The solution incorporates the Command Design Pattern and the State Pattern to provide a flexible and extensible structure.
- **TDD (Test-Driven Development)**: The development process follows TDD principles, ensuring that tests are written before the corresponding code.
- **SOLID Principles**: The codebase adheres to SOLID principles, promoting maintainability, scalability, and a clean architecture.

## Getting Started

### Prerequisites

Make sure you have the following installed on your machine:

- [.NET](https://dotnet.microsoft.com/download)

### Clone the Repository

```bash
git clone [https://github.com/amlsantos/marsRover-tdd-kata.git)
cd marsRover-tdd-kata
```

### Build and Run Tests
```bash
dotnet build
dotnet test
```

# Mars Rovers Kata - Requirements

This coding exercise simulates the movement of rovers on the surface of Mars. Below are the detailed requirements for the Mars Rovers Kata.

## 1. Surface Size

The surface of Mars is represented by a rectangular grid.

## 2. Rover Position

Each rover has a position consisting of an x-coordinate, y-coordinate, and a direction (N, S, E, W).

## 3. Commands

A rover can receive a string of commands:
- 'L' for left
- 'R' for right
- 'F' for move foward

## 4. Wrapping

The rover wraps around the edges of the grid if it reaches the boundary.

## 5. Obstacles

The surface may contain obstacles at specific coordinates, and rovers should avoid colliding with them.

## 6. Communication

Rovers communicate their final position and any obstacle encountered.

For a more detailed description and examples, please refer to the [Kata Catalog - Mars Rovers Kata](https://kata-log.rocks/mars-rover-kata).

# Mars Rovers Kata - Project Structure

This section provides an overview of the project structure for the Mars Rovers Kata.

## Directory Structure

```plaintext
mars-rovers-kata/
|-- src/
|   |-- Domain/
|       |-- Rovers/
|           |-- Commands/
|           |-- Directions/
|           |-- Point.cs
|           |-- Rover.cs
|           |-- RoverFactory.cs
|       |-- MarsRover.cs
|   |-- UI/
|           |-- Program.cs
|-- tests/
|   |-- UnitTests/
|       |-- MarsRoverTests.cs
|-- .gitignore
|-- MarsRoversKata.sln
|-- README.md
```

# How to Contribute

We welcome contributions to enhance the Mars Rovers Kata project. Follow the steps below to contribute:

## Contributing Guidelines

1. **Fork the repository**: Click the "Fork" button on the top right of the [marsRover-tdd-kata](https://github.com/amlsantos/marsRover-tdd-kata).

2. **Clone your fork**: Clone the repository to your local machine.

    ```bash
    git clone marsRover-tdd-kata
    cd marsRover-tdd-kata
    ```

3. **Create a new branch**: Create a new feature branch, from the starting point:

    ```bash
    git checkout 2dd7520
    git switch -c start 
    ```

4. **Make changes**: Implement your changes, following TDD.

5. **Run tests**: Ensure that all tests pass before submitting your changes.

    ```bash
    dotnet test
    ```

# Mars Rovers Kata - Acknowledgments

- [Jason Gorman](https://codemanship.co.uk/parlezuml/blog/?postid=1057): The original creator of the Mars Rovers Kata, providing a challenging and engaging coding exercise.

- [Indiana Codes](https://www.youtube.com/watch?v=_hdanhfIAUI): For his solution, that inspired this repo



