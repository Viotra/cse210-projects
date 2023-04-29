using System;

public class Entry
{
    //This will store the combined inputs from the user entry prompts
    public List<string> _entries = new List<string>();
    DateOnly _today = DateOnly.FromDateTime(DateTime.Now);

    //List to hold entry menu options
    List<string> _menu = new List<string>()
        {
            "1. Random prompts",
            "2. Formatted Entry",
            "3. Custom Entry"
        };
    
    //List of random prompts to meet project requirements
    List<string> _entryPrompts = new List<string>()
    {
        "What is something you accomplished today? ",
        "What is a goal that you set for the near future? ",
        "How was your overall emotional state today?",
        "What lesson did you learn today? ",
        "Is there anything that you would like future generations to remember? "
    };

    //Allow user to interact with the menu
    public void EntryMenu()
    {
        foreach (string option in _menu)
        {
            Console.WriteLine(option);
        }

        string menuOption = Console.ReadLine();

        if (menuOption == "1")
        {
            AddRandomEntry();
        }
        else if (menuOption == "2")
        {
            AddFormattedEntry();
        }
        else if (menuOption == "3")
        {
            AddCustomEntry();
        }
    }

    //User can choose how many entries they would like to create and then entries are selected at random
    void AddRandomEntry()
    {
        Console.Write("How many entries would you like to make? ");
        int numOfEntries = int.Parse(Console.ReadLine());
        for (int i =1; i <= numOfEntries; i++)
        {
            Random random = new Random();
            int randomIndex = random.Next(_entryPrompts.Count);

            Console.WriteLine(_entryPrompts[randomIndex]);
            string entry = Console.ReadLine();

            _entries.Add($"{_today}, {_entryPrompts[randomIndex]}, {entry}");
        }
    }

    //Structured prompts to create an entry using a specific format
    public void AddFormattedEntry()
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

        _entries.Add($"{_today}, Formatted Entry, I went to {response1} with {response2}. I/We went to {response3}. While I/we were there, {response4}. I felt {response5}.");
    }  

    //Allow user to add what they choose to the journal regardless of prompts
    public void AddCustomEntry()
    {
        Console.WriteLine("Please add your entry: ");
        string entry = Console.ReadLine();
        _entries.Add($"{_today}, Customer Entry, {entry}");
    } 
}