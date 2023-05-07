using System;

public class CsvToDictionary
{
    //private string _fileName = "kjv_strongs.csv";
    private List<string> bible = System.IO.File.ReadAllLines("kjv.csv").ToList();
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse; //Never utitlized. Ran out of time to use item.
    private string _scripture;

    //Constructor assigns values to all attributes in class using a line from the referenced csv file.
    public CsvToDictionary()
    {
        List<string> bibleElements = GetRandomScripture();

        _book = bibleElements[1];
        _chapter = bibleElements[3];
        _startVerse = bibleElements[4];
        if (bibleElements[5] == "")
        {
            _scripture = bibleElements[6];
        }
        else
        {
            _scripture = bibleElements[5];
        }
    }

    //grabs a line at random from the bible list and breaks up line to pass individual values to constructor.
    private List<string> GetRandomScripture()
    {
        Random random = new Random();
        int randomIndex = random.Next(bible.Count);
        string randomVerse = bible[randomIndex];

        List<string> bibleElements;

        if (randomVerse.Contains('"'))
        {
            string[] separateScripture = randomVerse.Split('"');
            bibleElements = separateScripture[0].Split(',').ToList<string>();
            bibleElements.Add(separateScripture[1]);
            
        }
        else{
            bibleElements = randomVerse.Split(',').ToList<string>();
        }

        return bibleElements;
    }

    //returns a tuple to be used by ScriptureReference class to build reference.
    public (string, string, string) GetScriptureReference()
    {
        
        return (_book, _chapter, _startVerse);
    }

    //just returns the random scripture text
    public string GetScripture()
    {
        return _scripture;
    }
}