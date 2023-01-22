/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        string input;
        do
        {
        Console.WriteLine("Do you want to continue ");
        input =Console.ReadLine();
        }
      while (input=="yes");
    }
}
*/
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
/*using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      
      /*string writeText = "Hello World!";  // Create a text string
      File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

      string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
      Console.WriteLine(readText); // Output the content*/
      // Create fille//
      /*TextWriter file = new StreamWriter("cs210.txt");
      Console.WriteLine("Please enter your text");
      string message=Console.ReadLine().ToString();
      file.WriteLine(message);
      file.Close();

      //readin file
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
}
*/

using System;
namespace MyAplication{
  class Program{
    static void Main(string[] args)
    {

      Console.WriteLine("Hello World");
    }
    static void DateTime(){
      Console.WriteLine("This is the date");
      DateTime theCurrentTime = DateTime.Now;
      string dateText = theCurrentTime.ToShortDateString();
      //string text2= Console.ReadLine().ToString();
      Console.WriteLine(dateText);

    }
  }
}