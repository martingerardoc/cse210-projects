public class scripture

    {
        public void Scripture(){
            string writeText = "3 Therefore, if ye have desires to serve God ye are acalled to the work;For behold the afield is white already to bharvest; and lo, he that thrusteth in his sickle with his might, the same layeth up in cstore that he perisheth not, but bringeth salvation to his soul;5 And afaith, bhope, ccharity and dlove, with an eeye single to the fglory of God, gqualify him for the work.";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content

        }
      
      
    }
