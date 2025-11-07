using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "m";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Final grade: {letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you have failed this class, but don't give up! You can retake the course. You will surely do better next time!");
        }
    }
}