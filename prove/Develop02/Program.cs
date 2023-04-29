/*What makes my program different is that I have added warnings to the save and 
load options that data may be overwritten or deleted by continuing, users will 
exit the save/load menus if they choose not to continue. I also added a sub-menu
to the entries class to allow users to select random entries, a formatted entry,
or to enter a custom entry.
*/

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