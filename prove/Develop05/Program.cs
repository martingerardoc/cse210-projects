using System;

class Program
{
    private static string simple;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        string input;
        do
        {
        Console.WriteLine("Welcome to Eternal Quest Program!");
        Console.WriteLine("Please select one of the folowing choices:");
        Console.WriteLine("1. Create a new goal.");
        Console.WriteLine("2. List Goals.");
        Console.WriteLine("3. Save Goals.");
        Console.WriteLine("4. Load Goals.");
        Console.WriteLine("5. Record Event.");
        Console.WriteLine("6. Quit.");
        input =Console.ReadLine();
        if(input=="1"){
          Console.WriteLine("your choice was 1");
          Goals goals = new Goals();
          goals.goals();

        
          Console.ReadLine();
        }
        else if (input=="2"){
          Console.WriteLine("your choice was 2");
          Console.ReadLine();
        }
        else if (input=="3"){
          Console.WriteLine("your choice was 3");
          Console.ReadLine();
        }
        else if (input=="4"){
          Console.WriteLine("your choice was 4");
          Console.WriteLine("you chooce to load your goals");
          Console.ReadLine();
        }
        else if (input=="5"){
          Console.WriteLine("your choice was 5");
          Console.ReadLine();
        }
        }
      while (input!="6");
      Console.WriteLine("Thanks for using the Eternal Quest Program.");
      Console.ReadLine();
    }
}