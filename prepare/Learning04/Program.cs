using System;
using Learning04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assigment objAssigment = new Assigment();
        objAssigment.GetSummary("Cespedes Martin", "Multiplication");

        mathAssigment objmathAssigment = new mathAssigment();
        objmathAssigment.getHomeworkList("7.3", "8-19");
       
       writingAssigment objwritingAssigment = new writingAssigment();
       objwritingAssigment.getWritingInformation("The Causes of World War II.");

       Console.WriteLine($"Student information \n Student Name: {objAssigment.StudentName} \n Topic: {objAssigment.Topic} ");
       Console.WriteLine($"Math Assigment \n Text Book Section: {objmathAssigment.TextBookSection} \n Problems: {objmathAssigment.Problems}");
       Console.WriteLine($"Writing Assigment: \n Title: {objwritingAssigment.Title}");
    }
}