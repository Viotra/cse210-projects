using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your first name? ");
        // string first_name = Console.ReadLine();
        // Console.Write("What is your last name? ");
        // string last_name = Console.ReadLine();

        // Console.WriteLine();

        // Console.Write($"Your name is {last_name}, {first_name} {last_name}.");

        // Probar preuba = new Probar("Test");
        // preuba.WriteSomething();

        string preuba = "This; is a test";
        bool getValue = preuba.Any(ch => char.IsPunctuation(ch));
        Console.Write(getValue);

        List<int> indeces = new List<int>();

        List<string> subs = new List<string>();

        int index = 0;

        foreach (char letter in preuba)
        {
           
            bool result = Char.IsPunctuation(letter);

            if (result == true)
            {
                indeces.Add(index);
            }
            index ++;
         
        }

        int indecesEntries = indeces.Count;
        for (int i = 0; i < indecesEntries; i++)
        {
            

            if (i == 0)
            {
                string sub = preuba.Substring(i, 1);
                subs.Add(sub);
            }
        }
    }
}