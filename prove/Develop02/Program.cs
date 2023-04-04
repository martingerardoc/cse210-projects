using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<string> journalEntries = new List<string>();
    static void Main(string[] args)
    {
      bool running = true;
        while (running)
        {
            Console.WriteLine("Please choose an option from the menu:");
            Console.WriteLine("1. Respond to a random prompt and save it as an entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Please enter your response to the prompt:");
                    string entry = Console.ReadLine();
                    journalEntries.Add(entry);
                    Console.WriteLine("Entry saved.");
                    break;
                case "2":
                    Console.WriteLine("Journal Entries:");
                    foreach (string journalEntry in journalEntries)
                    {
                        Console.WriteLine(journalEntry);
                    }
                    break;
                case "3":
                    Console.WriteLine("Please enter the file name to save the journal to:");
                    string fileName = Console.ReadLine();
                    File.WriteAllLines(fileName, journalEntries);
                    Console.WriteLine("Journal saved to file.");
                    break;
                case "4":
                    Console.WriteLine("Please enter the file name to load the journal from:");
                    fileName = Console.ReadLine();
                    if (File.Exists(fileName))
                    {
                        journalEntries = new List<string>(File.ReadAllLines(fileName));
                        Console.WriteLine("Journal loaded from file.");
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1-5.");
                    break;
            }
        }

        Console.WriteLine("Exiting program. Press any key to continue...");
        Console.ReadKey();






        // Console.WriteLine("Hello Learning03 World!");

        /*string input;
        do
        {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the folowing choices:");
        Console.WriteLine("1. Write.");
        Console.WriteLine("2. Display.");
        Console.WriteLine("3. Load.");
        Console.WriteLine("4. Save.");
        Console.WriteLine("5. Quit.");
        input =Console.ReadLine();
        if(input=="1"){
          Console.WriteLine("your choice was 1");
          Write();
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
          Console.ReadLine();
        }
        }
      while (input!="5");
      Console.WriteLine("Thanks for using the Journal Program.");
      Console.ReadLine();
    }
     static void Write() 
    {
      Console.WriteLine("please enter your text");
      Console.ReadLine();
      string writeText = "Hello World!";  // Create a text string
      File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

      string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
      Console.WriteLine(readText); 
      // Output the content
      // Create fille//
      TextWriter file = new StreamWriter("cs210.txt");
      Console.WriteLine("Please enter your text");
      string message=Console.ReadLine().ToString();
      file.WriteLine(message);
      file.Close();

      //reading file
      TextReader read_File= new StreamReader("cs210.txt");
      Console.WriteLine(read_File.ReadToEnd());
      read_File.Close();

      //Insert new tex to the file
      TextWriter file2 = File.AppendText("cs210.txt");
      //Console.WriteLine("inser another text to add to the file");
      Console.WriteLine("We are going to add the date");
      DateTime theCurrentTime = DateTime.Now;
      string dateText = theCurrentTime.ToShortDateString();
      //string text2= Console.ReadLine().ToString();
      file2.WriteLine(dateText);
      file2.Close();

      // Another reading file

      TextReader read_file2= new StreamReader("cs210.txt");
      Console.WriteLine(read_file2.ReadToEnd());
      read_file2.Close();
*/
    }
}
