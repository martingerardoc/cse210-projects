using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        string input;
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

    }
}
