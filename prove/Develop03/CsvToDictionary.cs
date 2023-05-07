using System;

public class CsvToDictionary
{
    //private string _fileName = "kjv_strongs.csv";
    private List<string> bible = System.IO.File.ReadAllLines("kjv.csv").ToList();
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;
    private string _scripture;

    public CsvToDictionary()
    {
        List<string> bibleElements = GetRandomScripture();

        _book = bibleElements[1];
        _chapter = bibleElements[3];
        _startVerse = bibleElements[4];
        _scripture = bibleElements[6];
    }
    public List<string> GetRandomScripture()
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

    public (string, string, string) GetScriptureReference()
    {
        
        return (_book, _chapter, _startVerse);
    }

    public string GetScripture()
    {
        return _scripture;
    }
}