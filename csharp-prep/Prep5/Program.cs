using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Prep5 World!");

        //Function to display a welcome message
       DisplayWelcomeMessage();
            static void DisplayWelcomeMessage()
         {
            Console.WriteLine("Welcome to the program!");
         }

        // Function to asks for and returns the user's name (as a string) 
           static string PromptUserName()
         {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
         }
         string userName=PromptUserName();


        //Funtion to asks for and returns the user's favorite number (as an integer)
           static int PromptUserNumber()
         {
            Console.Write("Please enter your favorite number: ");
             int number = int.Parse(Console.ReadLine());
              return number;
          }
         int userNumber = PromptUserNumber();

         // Function to accepts an integer as a parameter and returns that number squared (as an integer)
            static int SquareNumber(int number)
         {
            int square = number * number;
             return square;
         }
         // Function to accepts the user's name and the squared number and displays them.

            static void DisplayResult(string name, int square)
          {
             Console.WriteLine($"{name}, the square of your number is {square}");
         }
              int squaredNumber = SquareNumber(userNumber);

              DisplayResult(userName, squaredNumber);
                 static void EndProgram()
         {
            Console.WriteLine($"Thanks for your participation!!");
         }
              EndProgram();
    }
    
}