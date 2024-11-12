Horse Racing Game 🏇
This is a simple horse racing game developed in C# using Windows Forms. The game simulates a race between three horses, and the first one to cross the finish line is declared the winner.

📋 Overview
In this game, three PictureBoxes represent the horses. They move to the right at random intervals, simulating a race. When a horse crosses the finish line, the game stops, and a message displays the winning horse.

🎮 Features
Start Race: The player can start the race by clicking a button.
Random Movement: Each horse advances a random distance, making the game unpredictable.
Winner Declaration: When one of the horses crosses the finish line, the game ends and announces the winner.
🚀 How It Works
Start the Game: When starting, the game saves the initial positions of each horse.
Horse Movement: A timer controls each horse’s advancement, adding a random value to its position on each tick.
Determine the Winner: If the right edge of a horse reaches the finish line, the game stops and displays a message declaring the winner.
📂 Code Structure
Form1.cs: Contains the main game logic.
button1_Click: Starts the race by enabling the timer.
timer1_Tick: Controls the horses’ advancement and checks if any have reached the finish line.
Form1_Load: Sets the initial positions of the horses.
Resources Used: The game uses three PictureBoxes to represent the horses and a Timer to manage their movement.
💻 Prerequisites
Visual Studio or any other C# and Windows Forms-compatible environment.
.NET Framework 4.5 or higher.
