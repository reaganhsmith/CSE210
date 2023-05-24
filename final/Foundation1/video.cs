using System;
using System;

public class Video
{
    public string _videoName;
    public int _length;
    public string _creator;

    public List<Comments> _Comments = new List<Comments>();

    public int _commentNumbers;

    public void Display()
    {   
        Console.WriteLine(" ");
        Console.WriteLine($"Name: {_videoName}, {_length} seconds long");
        Console.WriteLine($"Created by: {_creator}");
        Console.WriteLine(" ");

        int commentsMade = _Comments.Count;
        Console.WriteLine($"There are  {commentsMade} comments on this post");
        Console.WriteLine("Comments: ");

        foreach (Comments comment in _Comments)
        {
            comment.Display();
        }
        Console.WriteLine("---------------------");
    }
}
