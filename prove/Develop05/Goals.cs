using System;

class Goals
{
    public void goals()
    {
        string info;
        Console.WriteLine("you choice to create a new goal");
         do
        {
        Console.WriteLine("Please select one of the folowing goals:");
        Console.WriteLine("1. Simple Goals.");
        Console.WriteLine("2. Eternal Goals.");
        Console.WriteLine("3. Checklist Goals.");
        Console.WriteLine("6. Quit.");
        info =Console.ReadLine();
        if(info=="1")
            {
          Console.WriteLine("your choice was 1");
          Console.WriteLine("Your choice is simple goals");
          simplegoals simple = new simplegoals();
          simple.simpleGoals();
          Console.ReadLine();
            }
        else if (info=="2")
            {
          Console.WriteLine("your choice was 2");
          eternalgoals eternal = new eternalgoals();
          eternal.eternalGoals();
          Console.ReadLine();
            }
        else if (info=="3")
            {
          Console.WriteLine("your choice was 3");
          Checklist check = new Checklist();
          check.ChecklistGoals();
          Console.ReadLine();
      
            }
            }
            while (info!="6");
            Console.WriteLine("Thanks for using this section of the Program.");
            Console.ReadLine(); 

    }
   
}