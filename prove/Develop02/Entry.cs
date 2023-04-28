using System;

public class Entry
{
    //This will store the combined inputs from the user entry prompts
    public List<string> _entries = new List<string>();
    DateOnly _today = DateOnly.FromDateTime(DateTime.Now);
    
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
        _entries.Add($"{_today} I went to {response1} with {response2}. I/We went to {response3}. While I/we were there, {response4}. I felt {response5}.");
    }   
}