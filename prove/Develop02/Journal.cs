using System;

public class Journal
{
    public string _ownerName;
    
    public string Prompt()
    {
        string menuOption;

        Console.WriteLine("1. New Entry \n2. Read Entries \n3. Save \n4. Load \n5. Quit");
        menuOption = Console.ReadLine();
        return menuOption;
    }

    //Function to save all files in the Entry._entries list
    public void SaveEntries(List<string> entries)
    {
        Console.WriteLine("What would you like to name your file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter saveFile = new StreamWriter (fileName))
        {
            foreach (string entry in entries){
                saveFile.WriteLine(entry);
            }
        }
    }

    // public List<string> LoadEntries()
    // {
    //     Console.WriteLine("Which file would you like to load? ");
    //     string fileName = Console.ReadLine();

    //     List<string> loadFile = System.IO.File.ReadAllLines(fileName).ToList();
    //     return loadFile;
    // }
    
    //This function reads all lines in a specified file, clear the entries list, and adds all file lines to the Entry._entries list
    public void LoadEntries(Entry entry)
    {
        Console.WriteLine("Which file would you like to load?");
        string fileName = Console.ReadLine();

        if (entry._entries.Count != 0)
        {
            entry._entries.Clear();
        }

        entry._entries = System.IO.File.ReadAllLines(fileName).ToList();
        Console.Write("Your file has loaded.");
        Console.ReadLine();
    }
}