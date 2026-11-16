# Blackjack — C# Console Game

A console-based Blackjack game developed in C# using .NET. This project was created to practice object-oriented programming, class design, collections, and game logic.

The game allows a player to play against a computer-controlled dealer following the basic rules of Blackjack.

---

## Features

- **52-card deck** — Standard deck containing four suits and thirteen ranks.
- **Card shuffling** — Randomized deck before each round.
- **Card dealing** — Draw cards from the deck during gameplay.
- **Hit or Stand** — Choose whether to draw another card or keep your current hand.
- **Hand scoring** — Automatically calculates the value of a player's hand.
- **Ace handling** — Aces can count as either 1 or 11 depending on the hand's total.
- **Face cards** — Jack, Queen, and King are worth 10 points.
- **Dealer AI** — The dealer automatically draws cards until reaching at least 17.
- **Blackjack detection** — Recognizes a natural Blackjack (21 with the first two cards).
- **Win/Loss/Tie detection** — Determines the outcome of each round.
- **Replay functionality** — Start another round without restarting the application.

---

## 🛠️ Technologies

| Technology | Purpose |
|---|---|
| C# | Main programming language |
| .NET | Application framework |
| Visual Studio | Development environment |
| Git & GitHub | Version control and source code hosting |

---

## Project Structure

```text
Blackjack/
│
├── Enums/
│   ├── Suit.cs
│   └── Rank.cs
│
├── Models/
│   ├── Card.cs
│   ├── Deck.cs
│   ├── Hand.cs
│   └── Player.cs
│
├── Services/
│   └── GameService.cs
│
├── Program.cs
└── README.md
```

### Class Responsibilities

| Class | Responsibility |
|---|---|
| `Suit` | Defines the four card suits. |
| `Rank` | Defines the thirteen card ranks. |
| `Card` | Represents an individual playing card. |
| `Deck` | Creates, shuffles, and manages the 52-card deck. |
| `Hand` | Stores a player's cards and calculates their score. |
| `Player` | Represents a player and manages their hand. |
| `GameService` | Controls the game flow, turns, and game results. |
| `Program` | Application entry point. |

---

## Game Rules

The game follows the basic rules of Blackjack:

1. Both the player and dealer receive two cards.
2. The player can choose to **Hit** (draw another card) or **Stand** (keep their current hand).
3. If the player's score exceeds 21, they lose immediately.
4. Once the player stands, the dealer plays automatically.
5. The dealer must draw cards until reaching a score of at least 17.
6. The player with the highest score without exceeding 21 wins.

### Card Values

| Card | Value |
|---|---:|
| Ace | 1 or 11 |
| 2–10 | Face value |
| Jack | 10 |
| Queen | 10 |
| King | 10 |

A natural Blackjack is achieved when a player receives an Ace and a 10-value card in their initial two cards.

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or another C# compatible IDE
- Git (optional, for cloning the repository)

### Installation

**1. Clone the repository**

```bash
git clone https://github.com/YOUR-USERNAME/Blackjack.git
```

**2. Navigate to the project directory**

```bash
cd Blackjack
```

**3. Restore dependencies**

```bash
dotnet restore
```

**4. Run the application**

```bash
dotnet run --project Blackjack
```

Alternatively, open `Blackjack.sln` in Visual Studio and run the project.

---

## Example Gameplay

```text
=== BLACKJACK ===

Player's hand:
Ten of Hearts
Seven of Clubs
Score: 17

Dealer's visible card:
Six of Diamonds

Hit or Stand? (H/S)
S

Dealer's turn...

Player's hand:
Ten of Hearts
Seven of Clubs
Score: 17

Dealer's hand:
Six of Diamonds
King of Spades
Score: 16

=== GAME RESULT ===
You win!
```

*Note: Gameplay output is illustrative. Actual cards and results are randomized.*

---

## Future Improvements

Potential features planned for future versions:

- [ ] Double Down
- [ ] Split pairs
- [ ] Betting system and virtual currency
- [ ] Improved console interface
- [ ] Better input validation and error handling
- [ ] Unit tests
- [ ] Improved dealer card visibility and game presentation

---

## Project Goals

The main objectives of this project are to:

- Refresh and strengthen C# programming skills.
- Apply object-oriented programming principles.
- Practice class responsibilities and encapsulation.
- Work with enums, lists, loops, and collections.
- Implement game logic and conditional statements.
- Build a small but structured application suitable for a personal portfolio.

---

## Author
Félix-Antoine Voyer

Developed as a personal C# learning and portfolio project.

**Built with C# and .NET.**