

# Tic-Tac-Toe Game

This is a simple Tic-Tac-Toe (XO) game developed using C# and Windows Forms. The game allows a player to compete against the computer, with the computer's moves being determined by a basic AI strategy.

## Features

- **Single Player Mode**: Play against the computer.
- **Cheating Mode**: Enable or disable a "Cheating Mode" where the computer has an advantage.
- **Score Tracking**: The game keeps track of how many times the player and the computer have won.
- **Reset Functionality**: Reset the game to start a new round.
- **User-Friendly Interface**: Intuitive and simple design for ease of play.

## Game Logic

The game board consists of a 3x3 grid of picture boxes that can be clicked by the player to make a move. The game automatically switches between the player and the computer, checking for a winner after each move.

### Player Moves

- The player starts the game and plays with the "X" symbol.
- The computer plays with the "O" symbol.
- The player can click on any empty box to make a move.

### Computer Moves

- The computer's move is determined by predefined win conditions, which it tries to satisfy to either win or block the player from winning.
- If no winning move is available, the computer will make a random move.

### Winning Conditions

The game checks for the following winning conditions after each move:

- Three symbols in a row (horizontal, vertical, or diagonal).
- If all boxes are filled without a winner, the game ends in a draw.

### Cheating Mode

The "Cheating Mode" gives the computer an advantage by allowing it to make two moves in one turn. This mode can be toggled on or off using a button in the UI.

## Getting Started

### Prerequisites

- Windows operating system.
- .NET Framework 4.7.2 or higher.

### Installation

1. Download The latest exe version from the release section and enjoy!!

## Usage

- Start the application to begin the game.
- Click on any empty box to make your move.
- The game will alternate between your move and the computer's move.
- Use the "Reset" button to start a new game.
- Toggle the "Cheating Mode" to enable or disable the computer's advantage.

## License

Please refer to the [LICENSE](https://github.com/Mohamed-SayedAlAhl/TicTacToe/blob/main/LICENSE) file for detailed licensing terms.

## Contact

For any questions or permission requests, please contact:

- [Mohamed Sayed Al-Ahl](https://www.linkedin.com/in/mohamed-sayedalahl/)
