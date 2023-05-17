using System;

class Program
{
    static void Main(string[] args)
    {

        List<shape> shapes = new List<shape>();

        Console.WriteLine("");



        square sq1 = new square("pink", 5);
        shapes.Add(sq1);

        rectangle rec2 = new rectangle("blue", 5, 4);
        shapes.Add(rec2);

        circle cir3 = new circle("purple", 8);
        shapes.Add(cir3);

        foreach(shape shape in shapes){
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The paper is {color} and the shape has an area of {area}");

        }


        Console.WriteLine("");
    }
}