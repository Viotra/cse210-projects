using System;

public class Journal
{
    public string _ownerName = "Tim";
    
    public string MenuPrompt()
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

        //This block will confirm with user if they wish to overwrite an already existing save file.
        if (File.Exists(fileName))
        {
            Console.Write($"{fileName} already exists. \nWould you like to overwrite saved file? (yes/no) ");
            string confirm = Console.ReadLine();

            if (confirm == "yes" || confirm == "y")
            {
                
            }
            else
            {
                return;
            }
        }

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

        //This block will confirm if a user would like to open a new file and delete all current entries.
        if (entry._entries.Count != 0)
        {
            Console.WriteLine("Warning, opening a new file will delete all current entries. \nDo you wish to continue? (yes/no) ");
            string confirm = Console.ReadLine();
            if (confirm == "yes" || confirm == "y"){
                entry._entries.Clear();
            }
            else{
                return;
            }
        }

        entry._entries = System.IO.File.ReadAllLines(fileName).ToList();
        Console.Write("Your file has loaded.");
        Console.ReadLine();
    }
}