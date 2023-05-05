using System;

public class Word
{
    private List<string> words = new List<string>();

    public Word ()
    {
        
    }
    public void SeparateWords(Scripture scripture)
    {
        string[] scriptureWords = scripture.GetScripture().Split(' ');
        
        foreach (string word in scriptureWords)
        {
            words.Add(word);
        }
    }


}