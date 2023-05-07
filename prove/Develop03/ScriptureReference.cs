using System;

public class ScriptureReference
{
    private string _book, _chapter, _startVerse, _endVerse;

    public ScriptureReference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = "";
    }

    public ScriptureReference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    // public void SetScriptureReference(Scripture scripture)
    // {

    // }
    public string GetScriptureReference()
    {
        string _scriputreReference;

        if (_endVerse == "")
        {
            _scriputreReference = $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            _scriputreReference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        return _scriputreReference;
    }
}