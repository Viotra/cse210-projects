using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        CsvToDictionary bible = new CsvToDictionary();
        var bibleElements = bible.GetScriptureReference();

        ScriptureReference reference = new ScriptureReference (bibleElements.Item1, bibleElements.Item2, bibleElements.Item3);
        Scripture scripture = new Scripture(reference.GetScriptureReference(), bible.GetScripture());
        
        string userEntry = "nothing";

        while (userEntry != "quit" && scripture.AllHidden() == false)
        {
            if (userEntry == "")
            {
                scripture.HideWord();
            }

            Console.Clear();
            scripture.ReadScripture();
            userEntry = Console.ReadLine();
        }
    }
}