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

        string gradeSecond = grade.Substring(1);
        int gradeSecNum = int.Parse(gradeSecond);

        string letter = " "; 
        string symbol = " ";

        if (gradeSecNum >= 7){
            symbol = "+";
        }
        else{
            symbol = "-";
        }
        if (gradeNumber >= 94)
        {
            letter = "A"; 
            Console.WriteLine($"Congrats you have an {letter}, you will pass the class!");
        }
        else if (gradeNumber <= 93)
        {
            letter = "A"; 
            Console.WriteLine($"Congrats you have an {letter}{symbol}, you will pass the class!");
        }
        else if (gradeNumber >= 80){
            letter = "B"; 
            Console.WriteLine($"Congrats you have an {letter}{symbol}, you will pass the class!");  
        }
        else if (gradeNumber >= 70){
            letter = "A"; 
            Console.WriteLine($"Congrats you have an {letter}{symbol}, you will pass the class!");    
        }
        else if (gradeNumber >= 60){
            letter = "A"; 
            Console.WriteLine("You have a D, you will NOT pass the class. Better luck next time");    
        }
        else
        {
            letter = "A"; 
             Console.WriteLine("You have a F, you will NOT pass the class. Better luck next time"); 
        }

        
    }
}

