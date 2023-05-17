public class rectangle : shape {

   private double _length;
   private double _width;

   public rectangle(string color, double width, double length) :base(color){
    _width = width;
    _length = length;
   }

    public override double GetArea()
    {
        return _length * _width;
    }

}