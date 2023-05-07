using System;
using System.Collections.Generic;


public class Scripture
{
    private string _reference;
    private string _scripture;

    private List<Word> _words = new List<Word>();

    private List<int> indeces = new List<int>();
    private List <string> subs = new List<string>();

    //string[] tempWords = GetScripture().Split(' ');
    
    //This constructor with no parameters will generate a random scripture.
    public Scripture(string reference, string scripture)
    {
        _reference = reference;
        splitVerse(scripture);
        
    }

    //This constructor will have a specific scripture to reference
    // public Scripture(Dictionary<string, string> userScripture)
    // {
    
    // }
    public void splitVerse(string scripture)
    {

        List<string> _brokenVerse = scripture.Split(' ').ToList();

        int indexInString = 0;

        foreach (string piece in _brokenVerse)
        {
        
        int indexInWord = 0;
        string wordText = piece;

        foreach (char letter in piece)
        {
           
            bool result = Char.IsPunctuation(letter);

            if (result == true)
            {
                string sub = piece.Substring(indexInWord, 1);
                subs.Add(sub);
                indeces.Add(indexInString);
                
                if (indexInWord == 0)
                {
                    wordText = piece.Substring(1);
                }
                else
                {
                    wordText = piece.Substring(0, indexInWord);
                }
                
            }
            indexInWord ++;

            
        }

        indexInString ++;
            
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void ReadScripture()
    {
        Console.WriteLine(_reference);

        string scripture = "";

        int wordIndex = 0;
        int itemIndex = 0;

        foreach (Word word in _words)
        {
            string punctuation = "";
            
            foreach (int item in indeces)
            {
                if (item == wordIndex)
                {
                    punctuation = subs[itemIndex];
                    itemIndex++;
                }
            }

            if (word.GetIsHidden() == false)
            {
                scripture += $"{word.GetWord()}{punctuation} ";
            }
            else
            {
                scripture += new string('_', word.GetWord().Length) + punctuation + " ";
            }

            wordIndex++;
        }

        Console.WriteLine(scripture);
    }
    

    public string GetScripture()
    {
        return _scripture;
    }

    public Word GetRandomWord()
    {
        Random random = new Random();
        int randomindexInWord = random.Next(_words.Count);
        return _words[randomindexInWord];
    }

    public bool AllHidden()
    {
        bool hidden = true;
        foreach (Word word in _words)
        {
            if (word.GetIsHidden() == false)
            {
                hidden = false;
            }
        }

        return hidden;
    }
    public void HideWord()
    {
        Word randomWord = GetRandomWord();

        bool hidden = false;

        while (hidden == false)
        {
            if (randomWord.GetIsHidden() == true)
            {
                randomWord = GetRandomWord();
            }
            else
            {
                randomWord.SetIsHidden(true);
                hidden = true;
            }
        }
    }
}