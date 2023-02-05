using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        string i;
        do 
            {
                Console.WriteLine("Please enter your selection");
                Console.WriteLine("scripture");
                Scripture();
                 i = Console.ReadLine();
            
            }
        while (i != "quit");
        Console.WriteLine("Thanks for used the application");
        //Random();
        Console.ReadLine();
        static void Scripture()
        {
            string writeText = "3 Therefore, if ye have desires to serve God ye are called to the work;For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with his might, the same layeth up in cstore that he perisheth not, but bringeth salvation to his soul;";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content

        }
        /*static void Random()
        {
            Random generator = new Random();
            int[]aleatory=new int[5];
            for (int i=0;i<5;i++)
            {
                aleatory[i]=generator.Next(1,50);
            }
            for (int i=0;i<5;i++)
            {
                Console.WriteLine(aleatory[i]);
            }
            Console.ReadKey();

        }*/
    }
     

}