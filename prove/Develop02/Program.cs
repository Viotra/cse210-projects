using System;

class Program
{
    static void Main(string[] args)
    {
        //List<string> entries = new List<string>();
        //Console.WriteLine("Hello Develop02 World!");
        string menuOption = "";
        Entry newEntry = new Entry();

        //DateTime newDate = DateTime.Now;

        while (menuOption != "5"){
            Journal journal = new Journal();
            menuOption = journal.MenuPrompt();
            //Console.Write(menuOption);

            if (menuOption == "1")
            {
                
                newEntry.EntryMenu();
                
            }
            else if(menuOption == "2")
            {
                Console.WriteLine(string.Join(',',newEntry._entries));
            }
            else if(menuOption == "3")
            {
                journal.SaveEntries(newEntry._entries);
            }
            else if(menuOption == "4")
            {
                journal.LoadEntries(newEntry);
                
            }
        }
    }
}