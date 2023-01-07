using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        //User needs to enter his gradess
        Console.Write("Please enter your grade percentage: ");
        string gradesFromStudent=Console.ReadLine();

        int G=int.Parse(gradesFromStudent);
        if(G==90){
            Console.WriteLine("Your grade is A");
        }
        else if(G>=90&&G<=95){
                Console.WriteLine("Your grade is A-");
            }
        else if (G>=95&&G<=100){
                Console.WriteLine("Your grade is A+");
            }
        if(G==80){
            Console.WriteLine("Your grade is B");
        }
        else if(G>=80&&G<=85){
                Console.WriteLine("Your grade is B-");
            }
        else if (G>=85&&G<=90){
                Console.WriteLine("Your grade is B+");
            }
        if(G==70){
            Console.WriteLine("Your grade is c");
        }
        else if(G>=70&&G<=75){
                Console.WriteLine("Your grade is C-");
            }
        else if (G>=75&&G<=80){
                Console.WriteLine("Your grade is C+");
            }
        if(G==60){
            Console.WriteLine("Your grade is D");
        }
        else if(G>=60&&G<=65){
                Console.WriteLine("Your grade is D-");
            }
        else if (G>=65&&G<=70){
                Console.WriteLine("Your grade is D+");
            }
        if(G<60){
            Console.WriteLine("Your grade is A");
        }
        else{
            Console.WriteLine("You need to enter a correct number");
        }
    }
        

}