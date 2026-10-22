# My Tic-Tac-Toe Game Project

A classic two-player Tic-Tac-Toe desktop game built with C# and the .NET Framework. This project is a simple Windows Forms application that lets two players take turns placing X and O marks on a 3x3 grid, detects wins or draws, and provides a reset option to start a new round.

## Overview

This project demonstrates a beginner-friendly Windows desktop application using C# WinForms. It includes:

- A 3x3 tic-tac-toe board
- Turn-based gameplay for two players
- Winner and draw detection
- Visual feedback for winning cells
- Game reset/restart functionality
- A polished desktop UI using graphical resources

## Project Structure

```text
MyTic-Tac-ToeGameProject/
├── App.config
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Program.cs
├── MyTic-Tac-ToeGameProject.csproj
├── MyTic-Tac-ToeGameProject.slnx
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.resx
│   ├── Resources.Designer.cs
│   ├── Settings.settings
│   └── Settings.Designer.cs
├── Resources/
│   ├── question-mark-96.png
│   ├── X.png
│   └── O.png
└── README.md
```

## Features

- Two-player local gameplay
- Automatic win checking along rows, columns, and diagonals
- Draw detection when all cells are filled without a winner
- Turn indicator showing whose move is next
- Restart button to reset the board
- Clean Windows Forms interface

## Requirements

Before running this project, make sure you have:

- Windows 10 or later
- Visual Studio 2019 or Visual Studio 2022
- .NET desktop development workload installed
- .NET Framework 4.7.2 targeting pack

## Installation

1. Clone the repository:

```bash
git clone https://github.com/essmatx/MyTic-Tac-ToeGameProject.git
```

2. Open the project in Visual Studio:
   - Open `MyTic-Tac-ToeGameProject.csproj` or the solution file.

3. Restore project dependencies if prompted.

4. Ensure the project targets `.NET Framework 4.7.2`.

5. Build the solution:
   - Press `F6` or choose `Build > Build Solution`.

6. Run the application:
   - Press `F5` or choose `Debug > Start Debugging`.

You can also run the compiled executable from:

```text
bin\Debug\MyTic-Tac-ToeGameProject.exe
```

## How to Use

1. Launch the game.
2. Player 1 starts with `X` and Player 2 follows with `O`.
3. Click any empty square on the board to place your mark.
4. The game automatically checks for a winner after each move.
5. If a row, column, or diagonal is completed, the game ends and a message box appears.
6. If no player wins after all nine moves, the game is declared a draw.
7. Click the restart button to start a new game.

## Gameplay Example

```text
Player 1: X
Player 2: O

Board:
[ ] [ ] [ ]
[ ] [ ] [ ]
[ ] [ ] [ ]
```

A player wins by making three matching marks in a row, column, or diagonal.

## Notes

This repository is intended as a straightforward educational desktop game project and is a good example of C# WinForms development, event-driven UI programming, and game logic implementation.

## Contributing

Contributions are welcome. If you want to improve the gameplay, UI, or code quality, feel free to fork the repository and submit a pull request.

## License

This project does not currently include an explicit license file. If you plan to reuse or distribute it, check with the repository owner before using it in a production or public project.
