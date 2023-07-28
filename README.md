# Carreaux - Automatic Card Dealer

**Carreaux** is an automatic card dealer console application written in C#. The application simulates a deck of French-style playing cards and provides functionalities to shuffle the deck, deal cards, and restart the game.

## Getting Started

To run the program, follow these steps:

1. Clone the repository to your local machine.
2. Make sure you have the latest version of the .NET SDK installed on your system.
3. Open the project in your favorite C# development environment (e.g., Visual Studio, Visual Studio Code).
4. Build and run the application.

Upon running the program, you will be greeted with a welcome message from Carreaux, the automatic card dealer.

## Functionality

The Carreaux application provides the following functionalities:

1. **Fresh Deck**: Initializes the deck of cards with a full set of 52 French-style playing cards.
2. **Deal**: Deals the top card from the deck and displays its rank and suit.
3. **Shuffle**: Shuffles the deck to randomize the order of the cards.
4. **Restart**: Allows the user to restart the game with a fresh deck after the entire deck has been dealt.

## Usage

1. When prompted, press **ENTER** to begin the game with a fresh deck of cards.
2. During the game, press **ENTER** to deal a new card from the deck.
3. To shuffle the deck, input **S** followed by **ENTER**.
4. To restart the game with a fresh deck, input **E** followed by **ENTER**.

## Card Representation

The application represents each card using two properties:

- **Rank**: The rank of the card (e.g., Ace, 2, 3, ..., 10, Jack, Queen, King).
- **Suit**: The suit of the card (♦ Diamonds, ♥ Hearts, ♣ Clubs, ♠ Spades).

## Note

The application does not include any user interface (UI) and is meant to be run in a console environment.

## Support

For any issues or questions regarding the Carreaux application, please open an issue on the GitHub repository.
