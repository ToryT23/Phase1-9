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

// Phase 3
// The program should be updated to...
// Give the user four chances to guess the number.
// Continue to display the success or failure messages as in phase 2

// Phase 4
// The program should be updated to...
// Display the number of the user's current guess in the prompt. 
// For example, if the user has already guessed one time, 
// the prommpt should say something like Your guess (2)>.
// End the loop early if the user guesses the correct number.

// Phase 5
// The program should be updated to...
// Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
// The prompt should display the number of guesses the user has left.
// int i = 0;

// Phase 6
// The program should be updated to...
// Inform the user if their guess was too high or too low, when they guess incorrectly.

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"How many chances left {4 - i}");

        Console.WriteLine("Guess a secret number?");
           string num = Console.ReadLine();
           int parsedInput = int.Parse(num);

Random rnd = new Random();
int secretNumber = rnd.Next(0,101);
if (parsedInput == secretNumber && i <= 4)
{
    Console.WriteLine("Great you got it");
    break;
}
else 
{
    Console.WriteLine("Sorry try again");
}

}