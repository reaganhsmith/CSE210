using System;

class Program
{
    static void Main(string[] args)
        {
    //     Console.WriteLine("Hello Prep1 World!");    

    //     Console.Write("What is your first name? ");
    //     string fname = Console.ReadLine();

    //     Console.Write("What is your last name? ");
    //     string lname = Console.ReadLine();

    //     Console.WriteLine($"Your name is {lname}, {fname} {lname}.");




        Console.WriteLine("What is you grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        if (gradeNumber >= 90)
        {
            Console.WriteLine("Congrats you have an A, you will pass the class!");
        }
        else if (gradeNumber >= 80){
            Console.WriteLine("Congrats you have an B, you will pass the class!");    
        }
        else if (gradeNumber >= 70){
            Console.WriteLine("Congrats you have an C, you will pass the class!");    
        }
        else if (gradeNumber >= 60){
            Console.WriteLine("You have a D, you will NOT pass the class. Better luck next time");    
        }
        else
        {
             Console.WriteLine("You have a F, you will NOT pass the class. Better luck next time"); 
        }

        
    }
}

