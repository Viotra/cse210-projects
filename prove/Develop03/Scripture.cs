using System;
using System.Collections.Generic;


public class Scripture
{
    private string _book;
    private string _chapter;
    private string _verse;

    private string _scripture;

    private List<string> brokenVerse = new List<string>();

    
    //This constructor with no parameters will generate a random scripture.
    public Scripture(string book, string chapter, string verse, string scripture)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _scripture = scripture;
        
    }

    //This constructor will have a specific scripture to reference
    // public Scripture(Dictionary<string, string> userScripture)
    // {
    
    // }

    public void ReadScripture()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
        Console.WriteLine(_scripture);
    }
    

    public string GetScripture()
    {
        return _scripture;
    }
}