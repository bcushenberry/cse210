public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;


    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public void GetVideoInfo()
    {
        Console.WriteLine($"Video: \"{_title}\"\nCreator: {_author}\nLength: {_length/60}m {_length%60}s\nComments: {_comments.Count()}");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetCommentInfo());
        }
        Console.WriteLine();
    }
}