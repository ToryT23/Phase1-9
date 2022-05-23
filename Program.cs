using System;

using System.Collections.Generic;
// Phase 1
// The program should...
// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a secret number?");
           string num = Console.ReadLine();
           Console.WriteLine($"{num}");
        }
    }
}
