
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();
    private bool _allHidden;

// The main constructor.
    public Scripture(string book, int chapter, int verse, int lastVerse, string text)
    {
        _reference = new Reference(book, chapter, verse, lastVerse);
        _words = new List<Word>();
        ParseScripture(text);
    }

// This empty constructor is here so we can call the GetScriptureList function using an empty scripture.
// I'm not sure if there's a better way to do this, but functionally it works.
    public Scripture()
    {

    }

// Created a method for parsing the scripture text into a List<Word>.
// It's not used outside the class at the moment, so I've set it to private.
    private void ParseScripture(string text)
    {
        string[] parsedText = text.Split();
        foreach (string str in parsedText)
        {
            Word word = new Word();
            word.SetWord(str);
            _words.Add(word);
        }
    }

// Method for loading a file into a List<Scripture>.
// I originally had this in Program, but since it's scripture-related, I moved it here.
// My only qualm with doing it this way is that we have to create an empty Scripture instance in Program in order to call it.
    public List<Scripture> GetScriptureList(List<Scripture> scriptures, string fileName)
    {
        scriptures.Clear();
        string[] loadedData = File.ReadAllLines(fileName);
        
        foreach (string line in loadedData)
        {
            string[] lines = line.Split("\t");
            Scripture newScripture = new Scripture(lines[0], int.Parse(lines[1]), int.Parse(lines[2]), int.Parse(lines[3]), lines[4]);
            scriptures.Add(newScripture);
        }
        return scriptures;
    }

// The Console.WriteLine("\n") is to match up the line breaks with the sample video.
    public void DisplayScripture()
    {
        Console.Write(_reference.GetReference() + " ");
        foreach (Word word in _words)
        {
            Console.Write(word.GetWord());
            Console.Write(" ");
        }
        Console.WriteLine("\n");
    }

// The video hides three words at a time, so I did the same thing here.
// However, if you load a scripture in with a word count that is not divisible
// by 3, the loop wouldn't end and the program would get stuck,
// which is why I added the AllHidden check at the beginning. 
    public void HideWords()
    {
        for (int j = 0; j < 3; j++)
            {
                if (AllHidden())
                {
                    break;
                }

                int i = _random.Next(_words.Count());

                if (_words[i].IsHidden())
                {
                    j--;                
                }
                
                _words[i].HideWord();
            }
    }

// Checks to see if everything in the scripture is hidden.
// Used for ending the program and breaking out of the "HideWords" loop if needed.
    public bool AllHidden()
    {       
        int numHiddenWords = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                numHiddenWords ++;
            }
        }

        if (numHiddenWords == _words.Count())
        {
            _allHidden = true;
        }
        return _allHidden;
    }
};