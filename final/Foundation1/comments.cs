public class Comments
{
    public string _name;
    public string _comment;

    public void Display()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine($"{_name}: {_comment}");
    }
}
