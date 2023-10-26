
public class Word
{
    private string _word;
    private bool _isHidden;

    public void SetWord(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }

    public Word()
    {
        _isHidden = false;
    }

    public Word(string word)
    {
        _word = word;
        _isHidden = false;        
        
    }

// There might be another way to do this, but this seemed simplest,
// since I can't think of a scenario where a word from the scriptures
// would contain an underscore.
    public bool IsHidden()
    {
        if (_word.Contains('_'))
        {
            _isHidden = true;
        }

        else
        {
            _isHidden = false;
        }
        return _isHidden;
    }

// Not sure if this is the best way to do this, but after trying
// at least a dozen different things and searching online a bunch,
// this is the best I could come up with.
    public void HideWord()
    {
        string newWord = new string('_', GetWord().Length);
        SetWord(newWord);
    }
};

