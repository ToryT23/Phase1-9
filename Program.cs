using System;

using System.Collections.Generic;
// Phase 1
// The program should...
// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.
// namespace GuessingGame
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Guess a secret number?");
//            string num = Console.ReadLine();
//            Console.WriteLine($"{num}");
//         }
//     }
// }

// Phase 2
// The program should be updated to...
// Create a variable to contain the secret number. This number should be hard-coded for now.
//  42 is a nice number.
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message
//  if the guess is correct, otherwise display a failure message.

// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

            Console.WriteLine("Guess a secret number?");
           string num = Console.ReadLine();
           int parsedInput = int.Parse(num);

        
    
int secretNumber = 42;
if (parsedInput == secretNumber)
{
    Console.WriteLine("Great you got it");
}
else
{
    Console.WriteLine("Sorry try again");
}