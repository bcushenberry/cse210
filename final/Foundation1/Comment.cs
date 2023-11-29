public class Comment
{
    private string _author;
    private string _comment;

    public Comment(string author, string comment)
    {
        _author = author;
        _comment = comment;
    }

    public string GetCommentInfo()
    {
        return $"Comment by {_author}: \"{_comment}\"";
    }
}