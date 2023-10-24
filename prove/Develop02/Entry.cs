using System;

public class Entry
{  
    public int _entryNumber;
    public string _dateText;
    public string _prompt;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"Entry #{_entryNumber}\tDate: {_dateText}\nPrompt: {_prompt}\nResponse: {_response}\n");
    }

    public string GetOutput()
    {
        return $"{_entryNumber}\t{_dateText}\t{_prompt}\t{_response}";

    }


}

