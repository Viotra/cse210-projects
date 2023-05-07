using System;

public class Word
{
    
    private string _word;
    private bool _hidden;

    //Constructor builds a Word object so that hidden value can be referenced to omit words later
    public Word (string word)
    {
        _word = word;
        _hidden = false;
    }

    //returns just value of the _word attribute
    public string GetWord()
    {
        return _word;
    }
    
    //returns the values of the _hidden attribute.
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

    //changes the _hidden value. Could have been done without a parameter by passing value false directly.
    public void SetIsHidden(bool hidden)
    {
        _hidden = hidden;
    }


}