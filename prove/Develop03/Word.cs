using System;

public class Word
{
    
    private string _word;
    private bool _hidden;
    public Word (string word)
    {
        _word = word;
        _hidden = false;
    }

    public string GetWord()
    {
        return _word;
    }
    
    public bool GetIsHidden()
    {

        if (_hidden == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void SetIsHidden(bool hidden)
    {
        _hidden = hidden;
    }


}