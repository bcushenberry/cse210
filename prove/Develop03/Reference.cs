
public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

// Rather than make two different constructors, I thought it would be more efficient
// to just make the lastVerse optional, so that's what I tried to do here and in the getter/setter.
    public Reference(string book, int chapter, int firstVerse, int lastVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    public string GetReference()
    {
        if (_lastVerse != 0)
        {
         return $"{_book} {_chapter}: {_firstVerse}-{_lastVerse}";
        }

        else
        {
        return $"{_book} {_chapter}: {_firstVerse}";
        }
    }

    public void SetReference(string book, int chapter, int firstVerse, int lastVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

};