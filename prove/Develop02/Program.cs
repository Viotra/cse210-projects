using System;

class Program
{
    static void Main(string[] args)
    {
        //List<string> entries = new List<string>();
        //Console.WriteLine("Hello Develop02 World!");
        string option = "";
        Entry newEntry = new Entry();

        while (option != "5"){
            Journal journal = new Journal();
            option = journal.Prompt();
            //Console.Write(option);

            if (option == "1")
            {
                
                newEntry.EntryPrompts();
                
            }
            else if(option == "2")
            {
                Console.WriteLine(string.Join(',',newEntry._entries));
            }
            else if(option == "3")
            {
                newEntry.SaveEntries();
            }
            else if(option == "4")
            {
                List<string> loadedFile = newEntry.LoadEntries();

                foreach (string line in loadedFile)
                {
                    newEntry._entries.Add(line);
                }
            }
        }
    }
}