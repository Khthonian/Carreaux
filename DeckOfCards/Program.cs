using System;
using System.Linq;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            while (true)
            {
                Console.WriteLine("Hello, I'm Carreaux, the Automatic Card Dealer\nPress SPACE to begin\nInput 'E' to exit\nPress ENTER to confirm\n");
                switch (Console.ReadLine().ToLower())
                {
                    case " ":
                        Console.WriteLine("Let's begin!");
                        deck.FreshDeck();
                        deck.Shuffle();
                        deck.CarreauxMenu();
                        break;
                    case "e":
                        Console.WriteLine("Thanks for using Carreaux, Automatic Card Dealer");
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }
    }

    public class Deck
    {
        // Add random function, to be used later when shuffling
        private readonly Random random = new Random();
        // Create a string list of all the suits in a standard deck of 52 french-style playing cards
        public List<string> Suits = new List<string> { "♦", "♥", "♣", "♠" };
        // Create a string list of all the ranks in a standard deck of 52 french style playing cards
        public List<string> Ranks = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" }; //List of values for the cards
        public Stack<Card> NewDeck { get; set; } // Property to handle the deck
        public void FreshDeck()
        {
            // Deck is set as a brand new stack
            NewDeck = new Stack<Card>();
            // Iterate through each suit, then through each rank respectively
            foreach (string suit in Suits)
            {
                foreach (string rank in Ranks)
                {
                    Card card = new Card
                    {
                        Suit = suit,
                        Rank = rank
                    };
                    // Push the new card onto the stack
                    NewDeck.Push(card);
                }
            }
            Console.WriteLine("\nI have created a new deck for you.\n");
        }

        public void CarreauxMenu()
        {
            // Check to see whether the stack is empty or not
            while (IsEmpty() != true)
            {
                Console.WriteLine("SPACE to deal a new card ~ S to Shuffle ~ E to exit\nPress ENTER to confirm");
                // Create a switch menu to handle in-game progression
                switch (Console.ReadLine().ToLower())
                {
                    case " ":
                        Deal();
                        break;
                    case "s":
                        Shuffle();
                        break;
                    case "e":
                        // Reset and create a fresh stack incase the player decides to play again
                        NewDeck = new Stack<Card>();
                        break;
                    default:
                        break;
                }

            }

        }

        public bool IsEmpty()
        {
            // Check to see whether the stack contains any entities
            if (NewDeck.Count == 0)
            {
                Console.WriteLine("\nThe deck has been completely dealt.");
                return true;
            }
            return false;
        }
        public void Shuffle()
        {
            // Convert the stack into a list in order to shuffle
            List<Card> list = NewDeck.ToList();
            int n = list.Count;
            while (n > 1)
            {
                // Shuffle the list by picking a random available index
                n--;
                int randomItem = random.Next(n + 1);
                Card value = list[randomItem];
                list[randomItem] = list[n];
                list[n] = value;
            }
            NewDeck = new Stack<Card>(list);
            Console.WriteLine("\nDeck Shuffled");
        }
        public void Deal()
        {
            // Peek the top value from the stack and write the appropriate card to the console in a string format. Subsequently, pop this value from the stack.
            Console.WriteLine($"I have dealt you the {NewDeck.Peek().Rank} of {NewDeck.Peek().Suit}");
            NewDeck.Pop();
        }
    }
}
