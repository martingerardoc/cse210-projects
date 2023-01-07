using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep1 World!");
        // We ask the user his name and his last name and showed on terminal.
        Console.WriteLine("what is your name?");
        String name=Console.ReadLine();
        Console.WriteLine("What is your last name?");
        String LastName=Console.ReadLine();
        Console.WriteLine($"your name is {LastName}, {name} {LastName}");
    }
}