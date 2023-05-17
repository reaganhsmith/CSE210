
public class circle : shape {

    private double _radius;

    public circle(string color, double radius) :base(color){
        _radius = radius;
    }

    public override double GetArea()
    {
        double pi = Math.PI;
        return pi * (Math.Pow(_radius, 2));
    }

}