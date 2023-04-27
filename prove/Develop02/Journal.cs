using System;

public class Journal
{
    public string _ownerName;
    public List<string> _entryFiles = new List<string>();
    public string Prompt()
    {
        string menuOption;

        Console.WriteLine("1. New Entry \n2. Read Entries \n3. Save \n4. Load \n5. Quit");
        menuOption = Console.ReadLine();
        return menuOption;
    }

    

}