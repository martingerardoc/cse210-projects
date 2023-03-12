using System;

class Text{
    public void text(){
        TextWriter file;
        file = new StreamWriter("file.txt");
        string message;
        message = Console.ReadLine();
        file.WriteLine(message);
        file.Close();
        Console.WriteLine("Your file was saved");
        Console.ReadKey();

    }
}