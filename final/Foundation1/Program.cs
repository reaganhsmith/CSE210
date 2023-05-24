using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._videoName = "Barry goes to the zoo";
        video1._length = 240;
        video1._creator = "Barrys_Mom_Karen_Smurf";

        Comments comment1 = new Comments();
        comment1._comment = "Awe the sea turtles were so cute!";
        comment1._name = "Barrys_GMA";

        Comments comment2 = new Comments();
        comment2._comment = "Wow Barry is one cute kid! Lucky mom";
        comment2._name = "Karen_Smurf_02";

        Comments comment3 = new Comments();
        comment3._comment = "This makes me want to go to the zoo";
        comment3._name = "Jeremy_Smurf_71";

        video1._Comments.Add(comment1);
        video1._Comments.Add(comment2);
        video1._Comments.Add(comment3);

        video1.Display();

        Console.WriteLine(" ");

        Video video2 = new Video();
        video2._videoName = "How many hot dogs can I eat??";
        video2._length = 640;
        video2._creator = "GlizzyLover345";

        Comments comment4 = new Comments();
        comment4._comment = "Wow my best record is only 22 hot dogs. Jealous. ";
        comment4._name = "LoverOfTheDog";

        Comments comment5 = new Comments();
        comment5._comment = "You better compete in this years hot dog contest!";
        comment5._name = "ILHotDogs";

        Comments comment6 = new Comments();
        comment6._comment = "Sad to see so many hot dogs go to waste :(";
        comment6._name = "AnimalWrites";

        Comments comment7 = new Comments();
        comment7._comment = "YOU GO BRO!! #Legit!!!";
        comment7._name = "MeeeetLvr";

        Comments comment8 = new Comments();
        comment8._comment = "This must me some tasty glizzeys. Makes me excited for the fourth of July!! AmIRight??";
        comment8._name = "Merica4Lyfe";

        video2._Comments.Add(comment4);
        video2._Comments.Add(comment5);
        video2._Comments.Add(comment6);
        video2._Comments.Add(comment7);
        video2._Comments.Add(comment8);

        video2.Display();
        Console.WriteLine(" ");


    }
}