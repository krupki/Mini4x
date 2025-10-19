# Mini-4X: A C# Console Strategy Simulation

## Overview

Mini-4X is a lightweight, turn-based strategy simulation running entirely in the .NET console. It serves as a foundational exercise in C# object-oriented programming, game loop management, and simple AI design.

The project demonstrates the core architecture of a simple "4X" (eXplore, eXpand, eXploit, eXterminate) style game. A player and an AI opponent navigate a dynamically generated world map.

**(It is highly recommended to add a screenshot or a GIF of the console application running here. Tools like ScreenToGif are excellent for this.)**

`![Mini-4X Gameplay Preview](gameplay.gif)`

---

## Core Features

* **Dynamic Map Generation:** A new, simple world map is procedurally generated every time the game starts.
* **Object-Oriented Units:** Player (`@`) and AI (`G`) are distinct objects inheriting from a base `Unit` class.
* **Turn-Based Game Loop:** The game progresses one turn at a time. The game world updates only after the player makes a move.
* **Player Control:** Full player movement using the arrow keys.
* **Simple AI Opponent:** A basic AI unit that moves randomly each turn, simulating an unpredictable opponent.
* **Console Rendering:** Uses advanced console commands (color, cursor positioning) to render the map and units efficiently.

---

## Technical Concepts Demonstrated

This project was built to showcase a strong understanding of core C# and software design principles:

* **Object-Oriented Programming (OOP):** The application is built around classes (`Map`, `Tile`, `Unit`, `Player`, `AIPlayer`), encapsulating state and behavior.
* **Inheritance:** The `Player` and `AIPlayer` classes both inherit from a base `Unit` class, promoting code reuse.
* **2D Arrays:** The world map is managed using a `Tile[,]` 2D array, demonstrating data structure management.
* **Game State Management:** The main `Program.cs` acts as a game engine, managing the central game loop (`while(gameRunning)`), and coordinating rendering, input, and updates.
* **Advanced Console I/O:**
    * Reading specific user input via `Console.ReadKey()`.
    * Using `Console.ForegroundColor` to add visual distinction.
    * Using `Console.SetCursorPosition()` to "draw" units on top of the map without re-rendering the entire grid.

---

## How to Run

This project is built using .NET.

1.  **Clone the repository:**
    ```sh
    git clone [https://github.com/YOUR-USERNAME/Mini4X.git](https://github.com/YOUR-USERNAME/Mini4X.git)
    ```

2.  **Navigate to the project directory:**
    ```sh
    cd Mini4X
    ```

3.  **Run the application:**
    ```sh
    dotnet run
    ```

---

## Project Structure

```
Mini4X/
├── Mini4X.csproj     # Project file
├── Program.cs        # Main game engine, game loop, and I/O
├── Map.cs            # Handles map generation and tile storage
├── Tile.cs           # Defines map tiles (Grassland, Water, etc.)
├── Unit.cs           # Base class for all mobile entities
├── Player.cs         # The user-controlled unit
└── AIPlayer.cs       # The simple AI-controlled unit
```
