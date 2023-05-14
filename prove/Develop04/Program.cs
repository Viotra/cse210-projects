using System;

/*Extra items: Created a menu class to keep more information encapsulated.
Added a few more personal animations to program and created a separate list
of follow up questions for each reflection question.*/
class Program
{
    public static CountdownEvent test = new CountdownEvent(1);
    static void Main(string[] args)
    {
        Console.Clear();
        Menu mainMenu = new Menu();
        mainMenu.MenuStart();
        Console.Clear();
    }
}