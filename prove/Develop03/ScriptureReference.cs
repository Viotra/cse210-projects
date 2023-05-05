using System;

public class scriptureReference
{
    private string _scriputreReference;

    public void SetScriptureReference(Scripture scripture)
    {
        _scriputreReference = scripture.CreateReference();
    }
    public string GetScriptureReference()
    {
        return _scriputreReference;
    }

    public string CreateReference()
    {
        string reference = _book + _chapter + _verse;
        return reference;
    }
}