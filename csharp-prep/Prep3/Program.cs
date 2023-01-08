using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        // Guess my number game
        //at this point the computer select a random number to guess

        Random randomGenerator = new Random();
        int rand = randomGenerator.Next(1, 11);

        // The user choose one number trying to guess the random number
        string input= "yes";
        while(input =="yes"){
             Console.WriteLine("Guess what is the magic number");
        String number = Console.ReadLine();
        int guess= int.Parse(number);
        Console.WriteLine($"your choice was {guess}");
        Console.WriteLine($"the random number is: {rand}");
         //Program to compare your choose and the random number
        if (rand>guess){
            Console.WriteLine("Sorry you dont guess the correct number");
            Console.WriteLine("Choose a higher number please");
        }
        else if (rand<guess){
            Console.WriteLine("Sorry you dont guess the correct number");
            Console.WriteLine("Choose a lower number please");
        }
        else {
            Console.WriteLine("CONGRATULATIONS YOU SELECTED THE CORRECT NUMNER AND YOU WIN");
            break;
        }
        Console.WriteLine("Do you want to play againg? Type yes/no");
        input=Console.ReadLine();
        }
        Console.WriteLine("Thanks for play");

       
    }
}