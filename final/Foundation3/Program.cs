using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Cookie Ave", "Milkyway Town", "Texas", "USA");
        Address address2 = new Address("1112 ChipsAhoy Way", "Castle Butte", "Colorado", "USA");
        Address address3 = new Address("2222 Ice Cream Drive ", "Valley View", "California", "USA");

        Lecture lecture = new Lecture("Art 2002", "An art class for intermediate to advanced artists", new DateTime(2023, 6, 15), new TimeSpan(9, 0, 0), address1, "Bob Ross", 65);
        Reception reception = new Reception("Celebrate Mindy & Chad", "Please come celebrate the marriage of Mindy and Chad", new DateTime(2023, 8, 5), new TimeSpan(12, 30, 0), address2, "rsvpEmail@gmail.com");
        Outdoor outdoor = new Outdoor("Wedding Cerimony", "outdoor Wedding of Monica and Tom", new DateTime(2023, 7, 25), new TimeSpan(6, 45, 0), address3, "82ºf");

        Console.WriteLine(" ");
        Console.WriteLine("SHORT DESCRIPTION:" + lecture.shortDescription());
        Console.WriteLine(" ");
        Console.WriteLine("STANDARD DESCRIPTION:" + lecture.getStandardDetails());
         
        Console.WriteLine("FULL DETAILS:" + lecture.fullDetails());
        Console.WriteLine(" ");

        Console.WriteLine("SHORT DESCRIPTION:" + reception.shortDescription());
        Console.WriteLine(" ");
        Console.WriteLine("STANDARD DESCRIPTION:" + reception.getStandardDetails());
         
        Console.WriteLine("FULL DETAILS:" + reception.fullDetails());
        Console.WriteLine(" ");

        Console.WriteLine("SHORT DESCRIPTION:" + outdoor.shortDescription());
        Console.WriteLine(" ");
        Console.WriteLine("STANDARD DESCRIPTION:" + outdoor.getStandardDetails());
         
        Console.WriteLine("FULL DETAILS:" + outdoor.fullDetails());
        Console.WriteLine(" ");




    }
}