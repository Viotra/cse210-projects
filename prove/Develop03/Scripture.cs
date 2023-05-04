using System;
using System.Collections.Generic;


public class Scripture
{
    private string _book;
    private string _chapter;
    private string _verse;
    
    //This constructor with no parameters will generate a random scripture.
    public Scripture(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    //This constructor will have a specific scripture to reference
    // public Scripture(Dictionary<string, string> userScripture)
    // {
    
    // }
}