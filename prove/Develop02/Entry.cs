using System;

public class Entry
{
    public List<string> _entries = new List<string>();

    public void EntryPrompts()
    {
        Console.WriteLine("Where did you go today? ");
        string response1 = Console.ReadLine();
        Console.WriteLine("Who did you go with? ");
        string response2 = Console.ReadLine();
        Console.WriteLine("What did you go to do? ");       
        string response3 = Console.ReadLine();
        Console.WriteLine("What happened? ");
        string response4 = Console.ReadLine();
        Console.WriteLine("How did you feel? ");
        string response5 = Console.ReadLine();
        _entries.Add($"I went to {response1} with {response2}. I/We went to {response3}. While we were there, {response4}. I felt {response5}.");
    }

    public void SaveEntries()
    {
        Console.WriteLine("What would you like to name your file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter saveFile = new StreamWriter (fileName))
        {
            foreach (string entry in _entries){
                saveFile.WriteLine(entry);
            }
        }
    }

    public List<string> LoadEntries()
    {
        Console.WriteLine("While file would you like to load? ");
        string fileName = Console.ReadLine();

        List<string> loadFile = System.IO.File.ReadAllLines(fileName).ToList();
        return loadFile;
    }
}