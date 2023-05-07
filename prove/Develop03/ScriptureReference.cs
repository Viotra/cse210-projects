using System;

public class ScriptureReference
{
    //strings declared to build reference
    private string _book, _chapter, _startVerse, _endVerse;

    //constructor will assign all attributes in class for a single verse
    public ScriptureReference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = "";
    }

    //constructor will assign all attributes in class for multiple verses
    public ScriptureReference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    //returns the scripture reference bases on if constructor was built with one verse or multiple. Multiple verse constructor
    //not currently utilized.
    public string GetScriptureReference()
    {
        string _scriputreReference;

        if (_endVerse == "")
        {
            _scriputreReference = $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            //Added this element to meet core requirements, ran out of time to utilize.
            _scriputreReference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        return _scriputreReference;
    }
}