# Prison Escape Console Game

## Overview
WIEZIENIEgra ("Prison Game") is a **C# console-based adventure game** where players navigate through various prison environments, solve challenges, and attempt to escape. The game features an interactive scene system, an inventory system, and a structured game loop to create an engaging text-based experience.

## Technologies Used
- **Language:** C#
- **Development Tools:** Visual Studio, Git
- **Game Architecture:** Object-Oriented Programming (OOP), Scene Management, Inventory System

## Features
### 🔹 Dynamic Scene System
- The game consists of multiple scenes (e.g., **Cell, Corridor, Canteen, Fight**), each represented as a class extending the `Scene` base class.
- A structured **game loop** handles scene transitions dynamically.

### 🔹 Player Inventory System
- Items are stored dynamically in a **dictionary-based inventory**, improving scalability over static boolean variables.
- Players can interact with objects, collect tools, and use them strategically.

### 🔹 Console-Based UI Enhancements
- **Colored text output** for better readability.
- **Animated transitions** to enhance player immersion.
- **Custom-built menu system** allowing player choices and navigation.

## How to Run the Game
1. **Clone the repository:**
   ```sh
   git clone https://github.com/your-repo/WIEZIENIEgra.git
   ```
2. **Open in Visual Studio** and build the solution (`WIEZIENIEgra.sln`).
3. **Run the game** using the terminal:
   ```sh
   dotnet run
   ```

## Code Structure
```
WIEZIENIEgra/
├── WIEZIENIEgra.sln        # Solution file
├── WIEZIENIEgra/           # Main game folder
│   ├── Game.cs             # Main game manager
│   ├── Player.cs           # Player inventory and actions
│   ├── Program.cs          # Entry point
│   ├── Menu.cs             # Menu navigation system
│   ├── Scene.cs            # Base class for game scenes
│   ├── Scenes/             # Folder for different game scenes
│   │   ├── CellScene.cs    
│   │   ├── FightScene.cs   
│   │   ├── CorridorScene.cs
│   │   ├── ...
└── README.md
```

## Potential Enhancements
- Implement a **save/load system** using JSON serialization.
- Introduce **sound effects and music** using `System.Media.SoundPlayer`.
- Refactor scene loading with a **Scene Factory** pattern.
- Expand **AI behavior** for guards or prisoners.
